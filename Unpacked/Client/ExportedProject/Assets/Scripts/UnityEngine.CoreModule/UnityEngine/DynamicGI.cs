namespace UnityEngine;

[NativeHeader("Runtime/GI/DynamicGI.h")]
[Token(Token = "0x200009B")]
public sealed class DynamicGI
{

	[Address(RVA = "0x1927930", Offset = "0x1926B30", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.SkyboxPreset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Lighting", Member = "set_AmbientSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.AmbientSource"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600032D")]
	public static void UpdateEnvironment() { }

}

