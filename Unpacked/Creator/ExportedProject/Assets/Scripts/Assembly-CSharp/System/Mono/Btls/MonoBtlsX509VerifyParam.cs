namespace Mono.Btls;

[Token(Token = "0x20000A6")]
internal class MonoBtlsX509VerifyParam : MonoBtlsObject
{
	[Token(Token = "0x20000A7")]
	public class BoringX509VerifyParamHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600031E")]
		public BoringX509VerifyParamHandle(IntPtr handle) { }

		[Address(RVA = "0x17327A0", Offset = "0x17319A0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600031F")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000080")]
	public bool CanModify
	{
		[Address(RVA = "0x1742050", Offset = "0x1741250", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600031A")]
		 get { } //Length: 154
	}

	[Token(Token = "0x1700007F")]
	internal BoringX509VerifyParamHandle Handle
	{
		[Address(RVA = "0x17420F0", Offset = "0x17412F0", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "Copy", ReturnType = typeof(MonoBtlsX509VerifyParam))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_CanModify", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600030E")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x928660", Offset = "0x927860", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000315")]
	internal MonoBtlsX509VerifyParam(BoringX509VerifyParamHandle handle) { }

	[Address(RVA = "0x17417E0", Offset = "0x17409E0", Length = "0x12D")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000316")]
	public MonoBtlsX509VerifyParam Copy() { }

	[Address(RVA = "0x1742050", Offset = "0x1741250", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600031A")]
	public bool get_CanModify() { }

	[Address(RVA = "0x17420F0", Offset = "0x17412F0", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "Copy", ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_CanModify", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600030E")]
	internal BoringX509VerifyParamHandle get_Handle() { }

	[Address(RVA = "0x1741910", Offset = "0x1740B10", Length = "0x35")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[Token(Token = "0x6000317")]
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	[Address(RVA = "0x1741950", Offset = "0x1740B50", Length = "0x35")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000318")]
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	[Address(RVA = "0x1741990", Offset = "0x1740B90", Length = "0x271")]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "GetSslClient", ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817320D0")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000319")]
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false) { }

	[Address(RVA = "0x1742170", Offset = "0x1741370", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000311")]
	private static int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	[Address(RVA = "0x17421F0", Offset = "0x17413F0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030F")]
	private static IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	[Address(RVA = "0x1742270", Offset = "0x1741470", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000314")]
	private static void mono_btls_x509_verify_param_free(IntPtr handle) { }

	[Address(RVA = "0x17422F0", Offset = "0x17414F0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000310")]
	private static IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	[Address(RVA = "0x1742370", Offset = "0x1741570", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000312")]
	private static int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	[Address(RVA = "0x1742410", Offset = "0x1741610", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000313")]
	private static int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	[Address(RVA = "0x1741C10", Offset = "0x1740E10", Length = "0x1AF")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817320D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031C")]
	public void SetHost(string name) { }

	[Address(RVA = "0x1741DC0", Offset = "0x1740FC0", Length = "0x19D")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031D")]
	public void SetTime(DateTime time) { }

	[Address(RVA = "0x1741F60", Offset = "0x1741160", Length = "0xE2")]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031B")]
	private void WantToModify() { }

}

