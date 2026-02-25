namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000058")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class TextGenerationInfo
{

	[Address(RVA = "0x1A5EC20", Offset = "0x1A5DE20", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "CacheTextGenerationInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000252")]
	public static IntPtr Create() { }

	[Address(RVA = "0x1A5EC50", Offset = "0x1A5DE50", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	public static void Destroy(IntPtr ptr) { }

}

