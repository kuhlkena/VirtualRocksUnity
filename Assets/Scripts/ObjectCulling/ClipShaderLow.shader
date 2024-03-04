Shader "Custom/DistanceClippingShaderLow"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _ClipDistance ("Clipping Distance", Float) = 10.0
    }
    SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;
        float _ClipDistance;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldPos;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            // Calculate the vector from the camera to the object
            float3 cameraToObject = _WorldSpaceCameraPos - IN.worldPos;

            // Calculate the distance by taking the magnitude of the vector
            float distance = length(cameraToObject);

            // Determine alpha based on distance and clipping threshold
            //clip(distance-_ClipDistance);
            float alpha = (distance - _ClipDistance) / 10.0;

            // Use the smoothstep function to create a smooth transition
            alpha = smoothstep(0.0, 1.0, alpha);

            // Pass the result to clip() to discard pixels below a certain threshold
            clip(alpha - 0.5);

            // Apply texture with modified alpha
            o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
