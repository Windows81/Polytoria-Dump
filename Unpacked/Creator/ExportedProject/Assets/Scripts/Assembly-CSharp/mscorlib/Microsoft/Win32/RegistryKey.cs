namespace Microsoft.Win32;

[Token(Token = "0x200007A")]
public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	[Token(Token = "0x200007B")]
	private enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8,
	}

	[Token(Token = "0x4000241")]
	internal static readonly IntPtr HKEY_CLASSES_ROOT; //Field offset: 0x0
	[Token(Token = "0x4000242")]
	internal static readonly IntPtr HKEY_CURRENT_USER; //Field offset: 0x8
	[Token(Token = "0x4000243")]
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; //Field offset: 0x10
	[Token(Token = "0x4000244")]
	internal static readonly IntPtr HKEY_USERS; //Field offset: 0x18
	[Token(Token = "0x4000245")]
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; //Field offset: 0x20
	[Token(Token = "0x4000246")]
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; //Field offset: 0x28
	[Token(Token = "0x4000247")]
	internal static readonly IntPtr HKEY_DYN_DATA; //Field offset: 0x30
	[Token(Token = "0x4000248")]
	private static readonly String[] s_hkeyNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000249")]
	private SafeRegistryHandle _hkey; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024A")]
	private string _keyName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024B")]
	private bool _remoteKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400024C")]
	private StateFlags _state; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024D")]
	private RegistryKeyPermissionCheck _checkMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400024E")]
	private RegistryView _regView; //Field offset: 0x34

	[Address(RVA = "0x12FC470", Offset = "0x12FB670", Length = "0x2E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000235")]
	private static RegistryKey() { }

	[Address(RVA = "0x12FC760", Offset = "0x12FB960", Length = "0x178")]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000223")]
	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	[Address(RVA = "0x12FA140", Offset = "0x12F9340", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Token(Token = "0x600021B")]
	private void ClosePerfDataKey() { }

	[Address(RVA = "0x12FA1A0", Offset = "0x12F93A0", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC290")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000224")]
	public override void Dispose() { }

	[Address(RVA = "0x12FA2C0", Offset = "0x12F94C0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022F")]
	private void EnsureNotDisposed() { }

	[Address(RVA = "0x12FA320", Offset = "0x12F9520", Length = "0x21F")]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022D")]
	private static string FixupName(string name) { }

	[Address(RVA = "0x12FA540", Offset = "0x12F9740", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600022E")]
	private static void FixupPath(StringBuilder path) { }

	[Address(RVA = "0x12FA680", Offset = "0x12F9880", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000222")]
	private static int GetRegistryKeyAccess(bool isWritable) { }

	[Address(RVA = "0x12FA6A0", Offset = "0x12F98A0", Length = "0x183")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	public String[] GetSubKeyNames() { }

	[Address(RVA = "0x12FA830", Offset = "0x12F9A30", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000230")]
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	[Address(RVA = "0x12FA890", Offset = "0x12F9A90", Length = "0x11D")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneEntryFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(string), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = "System.TimeZoneInfo+TimeZoneInfoResult")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600022A")]
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	[Address(RVA = "0x12FA6A0", Offset = "0x12F98A0", Length = "0x183")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000229")]
	private String[] InternalGetSubKeyNames() { }

	[Address(RVA = "0x12FA9B0", Offset = "0x12F9BB0", Length = "0x226")]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC2D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Advapi32), Member = "RegEnumKeyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(int), typeof(Char[]), typeof(Int32&), typeof(Int32[]), typeof(StringBuilder), typeof(Int32[]), typeof(Int64[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021F")]
	private String[] InternalGetSubKeyNamesCore(int subkeys) { }

	[Address(RVA = "0x12FB500", Offset = "0x12FA700", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022B")]
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	[Address(RVA = "0x12FABE0", Offset = "0x12F9DE0", Length = "0x8E8")]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryValueEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(Int32[]), typeof(Int32&), typeof(Int64&), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryValueEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(Int32[]), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryValueEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(Int32[]), typeof(Int32&), typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryValueEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(Int32[]), typeof(Int32&), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000220")]
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	[Address(RVA = "0x12FB5B0", Offset = "0x12FA7B0", Length = "0x1EC")]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Advapi32), Member = "RegOpenKeyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(string), typeof(int), typeof(int), typeof(SafeRegistryHandle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowSecurityException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021D")]
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	[Address(RVA = "0x12FB840", Offset = "0x12FAA40", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000227")]
	private int InternalSubKeyCount() { }

	[Address(RVA = "0x12FB7A0", Offset = "0x12FA9A0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Advapi32), Member = "RegQueryInfoKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(StringBuilder), typeof(Int32[]), typeof(IntPtr), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32&), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600021E")]
	private int InternalSubKeyCountCore() { }

	[Address(RVA = "0x12FB940", Offset = "0x12FAB40", Length = "0x1A")]
	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000234")]
	private bool IsPerfDataKey() { }

	[Address(RVA = "0x12FB960", Offset = "0x12FAB60", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000233")]
	private bool IsSystemKey() { }

	[Address(RVA = "0x12FBAE0", Offset = "0x12FACE0", Length = "0x1E5")]
	[CalledBy(Type = typeof(Registry), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000225")]
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	[Address(RVA = "0x12FB980", Offset = "0x12FAB80", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021C")]
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	[Address(RVA = "0x12FBCD0", Offset = "0x12FAED0", Length = "0xD8")]
	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<.cctor>b__157_0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = "System.TimeZoneInfo+TimeZoneInfoResult")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000226")]
	public RegistryKey OpenSubKey(string name, bool writable) { }

	[Address(RVA = "0x12FBDB0", Offset = "0x12FAFB0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022C")]
	public virtual string ToString() { }

	[Address(RVA = "0x12FBE20", Offset = "0x12FB020", Length = "0x443")]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000231")]
	private static void ValidateKeyName(string name) { }

	[Address(RVA = "0x12FC270", Offset = "0x12FB470", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000232")]
	private static void ValidateKeyView(RegistryView view) { }

	[Address(RVA = "0x12FC2D0", Offset = "0x12FB4D0", Length = "0x197")]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCountCore", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegistryKey), Member = "IsPerfDataKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000221")]
	private void Win32Error(int errorCode, string str) { }

}

