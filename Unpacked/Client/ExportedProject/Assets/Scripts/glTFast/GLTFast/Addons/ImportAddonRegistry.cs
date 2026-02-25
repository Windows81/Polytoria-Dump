namespace GLTFast.Addons;

[Token(Token = "0x200014B")]
public static class ImportAddonRegistry
{
	[Token(Token = "0x4000478")]
	private static List<ImportAddon> s_Addons; //Field offset: 0x0

	[Address(RVA = "0x1090F10", Offset = "0x1090110", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000382")]
	private static void CertifyDefaultAddonsRegistered() { }

	[Address(RVA = "0x1090FC0", Offset = "0x10901C0", Length = "0x1BF")]
	[CalledBy(Type = typeof(GltfImportBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000381")]
	internal static void InjectAllAddons(GltfImportBase gltfImport) { }

}

