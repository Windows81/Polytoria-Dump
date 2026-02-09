Shader "glTF/PbrSpecularGlossiness" {
	Properties {
		baseColorFactor ("Diffuse", Vector) = (1,1,1,1)
		baseColorTexture ("Diffuse Tex", 2D) = "white" {}
		baseColorTexture_Rotation ("Diffuse Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] baseColorTexture_texCoord ("Diffuse Tex UV", Float) = 0
		alphaCutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
		glossinessFactor ("Glossiness", Range(0, 1)) = 1
		specularFactor ("Specular", Vector) = (1,1,1,1)
		specularGlossinessTexture ("Specular-Glossiness Tex", 2D) = "white" {}
		specularGlossinessTexture_Rotation ("Specular-Glossiness Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] specularGlossinessTexture_texCoord ("Specular-Glossiness Tex UV", Float) = 0
		normalTexture_scale ("Normal Scale", Float) = 1
		[Normal] normalTexture ("Normal Tex", 2D) = "bump" {}
		normalTexture_Rotation ("Normal Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] normalTexture_texCoord ("Normal Tex UV Set", Float) = 0
		occlusionTexture_strength ("Occlusion Strength", Range(0, 1)) = 1
		occlusionTexture ("Occlusion Tex", 2D) = "white" {}
		occlusionTexture_Rotation ("Occlusion Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] occlusionTexture_texCoord ("Occlusion Tex UV Set", Float) = 0
		[HDR] emissiveFactor ("Emissive", Vector) = (0,0,0,1)
		emissiveTexture ("Emissive Tex", 2D) = "white" {}
		emissiveTexture_Rotation ("Emissive Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] emissiveTexture_texCoord ("Emissive Tex UV", Float) = 0
		[HideInInspector] _Mode ("__mode", Float) = 0
		[HideInInspector] _SrcBlend ("__src", Float) = 1
		[HideInInspector] _DstBlend ("__dst", Float) = 0
		[HideInInspector] _ZWrite ("__zw", Float) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("Cull Mode", Float) = 2
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "VertexLit"
	//CustomEditor "GLTFast.Editor.BuiltInShaderGUI"
}