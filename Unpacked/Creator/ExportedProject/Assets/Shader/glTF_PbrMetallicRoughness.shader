Shader "glTF/PbrMetallicRoughness" {
	Properties {
		baseColorFactor ("Base Color", Vector) = (1,1,1,1)
		baseColorTexture ("Base Color Tex", 2D) = "white" {}
		baseColorTexture_Rotation ("Base Color Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] baseColorTexture_texCoord ("Base Color Tex UV", Float) = 0
		alphaCutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
		roughnessFactor ("Roughness", Range(0, 1)) = 1
		[Gamma] metallicFactor ("Metallic", Range(0, 1)) = 1
		metallicRoughnessTexture ("Metallic-Roughness Tex", 2D) = "white" {}
		metallicRoughnessTexture_Rotation ("Metallic-Roughness Map Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] metallicRoughnessTexture_texCoord ("Metallic-Roughness Tex UV", Float) = 0
		normalTexture_scale ("Normal Scale", Float) = 1
		[Normal] normalTexture ("Normal Tex", 2D) = "bump" {}
		normalTexture_Rotation ("Normal Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] normalTexture_texCoord ("Normal Tex UV", Float) = 0
		occlusionTexture_strength ("Occlusion Strength", Range(0, 1)) = 1
		occlusionTexture ("Occlusion Tex", 2D) = "white" {}
		occlusionTexture_Rotation ("Occlusion Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] occlusionTexture_texCoord ("Occlusion Tex UV", Float) = 0
		[HDR] emissiveFactor ("Emissive", Vector) = (0,0,0,1)
		emissiveTexture ("Emission Tex", 2D) = "white" {}
		emissiveTexture_Rotation ("Emission Tex Rotation", Vector) = (0,0,0,0)
		[Enum(UV0,0,UV1,1)] emissiveTexture_texCoord ("Emission Tex UV", Float) = 0
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