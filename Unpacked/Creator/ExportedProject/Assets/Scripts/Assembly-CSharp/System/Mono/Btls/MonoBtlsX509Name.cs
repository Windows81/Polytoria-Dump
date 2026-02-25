namespace Mono.Btls;

[Token(Token = "0x200009C")]
internal class MonoBtlsX509Name : MonoBtlsObject
{
	[Token(Token = "0x200009D")]
	public class BoringX509NameHandle : MonoBtlsHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C8")]
		private bool dontFree; //Field offset: 0x20

		[Address(RVA = "0x1732660", Offset = "0x1731860", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E0")]
		internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) { }

		[Address(RVA = "0x17325D0", Offset = "0x17317D0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002E1")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x1700007B")]
	internal BoringX509NameHandle Handle
	{
		[Address(RVA = "0x173EEC0", Offset = "0x173E0C0", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOidData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60002D7")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x928660", Offset = "0x927860", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D8")]
	internal MonoBtlsX509Name(BoringX509NameHandle handle) { }

	[Address(RVA = "0x173E550", Offset = "0x173D750", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DF")]
	public static MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

	[Address(RVA = "0x173EEC0", Offset = "0x173E0C0", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOidData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002D7")]
	internal BoringX509NameHandle get_Handle() { }

	[Address(RVA = "0x173E6E0", Offset = "0x173D8E0", Length = "0x91")]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "FormatName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DA")]
	public int GetEntryCount() { }

	[Address(RVA = "0x173E8E0", Offset = "0x173DAE0", Length = "0x232")]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DC")]
	public string GetEntryOid(int index) { }

	[Address(RVA = "0x173E780", Offset = "0x173D980", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DD")]
	public Byte[] GetEntryOidData(int index) { }

	[Address(RVA = "0x173EB20", Offset = "0x173DD20", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DB")]
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	[Address(RVA = "0x173EC10", Offset = "0x173DE10", Length = "0x205")]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "FreeDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DE")]
	public string GetEntryValue(int index, out int tag) { }

	[Address(RVA = "0x173EE20", Offset = "0x173E020", Length = "0x91")]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name)}, ReturnType = typeof(MonoBtlsX509))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D9")]
	public long GetHash() { }

	[Address(RVA = "0x173EF40", Offset = "0x173E140", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D6")]
	private static void mono_btls_x509_name_free(IntPtr handle) { }

	[Address(RVA = "0x173EFC0", Offset = "0x173E1C0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D5")]
	private static IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	[Address(RVA = "0x173F060", Offset = "0x173E260", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D0")]
	private static int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	[Address(RVA = "0x173F180", Offset = "0x173E380", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D2")]
	private static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	[Address(RVA = "0x173F0E0", Offset = "0x173E2E0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D3")]
	private static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	[Address(RVA = "0x173F220", Offset = "0x173E420", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D1")]
	private static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	[Address(RVA = "0x173F2B0", Offset = "0x173E4B0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002D4")]
	private static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	[Address(RVA = "0x173F350", Offset = "0x173E550", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CF")]
	private static long mono_btls_x509_name_hash(IntPtr handle) { }

}

