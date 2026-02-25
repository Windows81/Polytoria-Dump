//Type is in global namespace

[Token(Token = "0x2000002")]
internal static class Interop
{
	[Token(Token = "0x2000029")]
	public class Advapi32
	{

		[Address(RVA = "0x12D6270", Offset = "0x12D5470", Length = "0x78")]
		[CalledBy(Type = typeof(RegistryKey), Member = "ClosePerfDataKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RegistryKey), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SafeRegistryHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003A")]
		internal static int RegCloseKey(IntPtr hKey) { }

		[Address(RVA = "0x12D62F0", Offset = "0x12D54F0", Length = "0x18D")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8C0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003B")]
		internal static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Char[] lpName, ref int lpcbName, Int32[] lpReserved, out StringBuilder lpClass, Int32[] lpcbClass, Int64[] lpftLastWriteTime) { }

		[Address(RVA = "0x12D6480", Offset = "0x12D5680", Length = "0x166")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003C")]
		internal static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult) { }

		[Address(RVA = "0x12D65F0", Offset = "0x12D57F0", Length = "0x21F")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCountCore", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8C0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003D")]
		internal static int RegQueryInfoKey(SafeRegistryHandle hKey, out StringBuilder lpClass, Int32[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Int32[] lpcbMaxSubKeyLen, Int32[] lpcbMaxClassLen, ref int lpcValues, Int32[] lpcbMaxValueNameLen, Int32[] lpcbMaxValueLen, Int32[] lpcbSecurityDescriptor, Int32[] lpftLastWriteTime) { }

		[Address(RVA = "0x12D6A70", Offset = "0x12D5C70", Length = "0x19C")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Byte[] lpData, ref int lpcbData) { }

		[Address(RVA = "0x12D6810", Offset = "0x12D5A10", Length = "0x121")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003F")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData) { }

		[Address(RVA = "0x12D6940", Offset = "0x12D5B40", Length = "0x121")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000040")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData) { }

		[Address(RVA = "0x12D6C10", Offset = "0x12D5E10", Length = "0x1AD")]
		[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000041")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Char[] lpData, ref int lpcbData) { }

	}

	[Token(Token = "0x2000018")]
	public class BCrypt
	{
		[Token(Token = "0x2000019")]
		public enum NTSTATUS
		{
			STATUS_SUCCESS = 0,
			STATUS_NOT_FOUND = 3221226021,
			STATUS_INVALID_PARAMETER = 3221225485,
			STATUS_NO_MEMORY = 3221225495,
		}


		[Address(RVA = "0x12D72A0", Offset = "0x12D64A0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000031")]
		internal static NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, Byte* pbBuffer, int cbBuffer, int dwFlags) { }

	}

	[Token(Token = "0x200001B")]
	public enum BOOL
	{
		FALSE = 0,
		TRUE = 1,
	}

	[Token(Token = "0x200001C")]
	public enum BOOLEAN
	{
		FALSE = 0,
		TRUE = 1,
	}

	[Token(Token = "0x2000003")]
	public static class Kernel32
	{
		[Token(Token = "0x2000010")]
		public struct COPYFILE2_EXTENDED_PARAMETERS
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000030")]
			internal uint dwSize; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000031")]
			internal uint dwCopyFlags; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000032")]
			internal IntPtr pfCancel; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000033")]
			internal IntPtr pProgressRoutine; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000034")]
			internal IntPtr pvCallbackContext; //Field offset: 0x18

		}

		[Token(Token = "0x2000011")]
		public enum FILE_INFO_BY_HANDLE_CLASS
		{
			FileBasicInfo = 0,
			FileStandardInfo = 1,
			FileNameInfo = 2,
			FileRenameInfo = 3,
			FileDispositionInfo = 4,
			FileAllocationInfo = 5,
			FileEndOfFileInfo = 6,
			FileStreamInfo = 7,
			FileCompressionInfo = 8,
			FileAttributeTagInfo = 9,
			FileIdBothDirectoryInfo = 10,
			FileIdBothDirectoryRestartInfo = 11,
			FileIoPriorityHintInfo = 12,
			FileRemoteProtocolInfo = 13,
			FileFullDirectoryInfo = 14,
			FileFullDirectoryRestartInfo = 15,
		}

		[Token(Token = "0x2000012")]
		public struct FILE_TIME
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000046")]
			internal uint dwLowDateTime; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000047")]
			internal uint dwHighDateTime; //Field offset: 0x4

			[Address(RVA = "0x12D82A0", Offset = "0x12D74A0", Length = "0x7B")]
			[CalledBy(Type = typeof(FileSystem), Member = "GetCreationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(FileSystem), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeCore", ReturnType = typeof(DateTimeOffset))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeUtc", ReturnType = typeof(DateTime))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
			[Token(Token = "0x600002F")]
			internal DateTimeOffset ToDateTimeOffset() { }

			[Address(RVA = "0x12D8320", Offset = "0x12D7520", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600002E")]
			internal long ToTicks() { }

		}

		[Token(Token = "0x2000013")]
		public enum FINDEX_INFO_LEVELS
		{
			FindExInfoStandard = 0,
			FindExInfoBasic = 1,
			FindExInfoMaxInfoLevel = 2,
		}

		[Token(Token = "0x2000014")]
		public enum FINDEX_SEARCH_OPS
		{
			FindExSearchNameMatch = 0,
			FindExSearchLimitToDirectories = 1,
			FindExSearchLimitToDevices = 2,
			FindExSearchMaxSearchOp = 3,
		}

		[Token(Token = "0x2000015")]
		public enum GET_FILEEX_INFO_LEVELS
		{
			GetFileExInfoStandard = 0,
			GetFileExMaxInfoLevel = 1,
		}

		[Token(Token = "0x2000007")]
		public struct REG_TZI_FORMAT
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400000E")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400000F")]
			internal int StandardBias; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000010")]
			internal int DaylightBias; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000011")]
			internal SYSTEMTIME StandardDate; //Field offset: 0xC
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000012")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x1C

			[Address(RVA = "0x12DD700", Offset = "0x12DC900", Length = "0x27")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x6000028")]
			internal REG_TZI_FORMAT(in TIME_ZONE_INFORMATION tzi) { }

		}

		[Token(Token = "0x2000016")]
		public struct SECURITY_ATTRIBUTES
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000054")]
			internal uint nLength; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000055")]
			internal IntPtr lpSecurityDescriptor; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000056")]
			internal BOOL bInheritHandle; //Field offset: 0x10

		}

		[Token(Token = "0x2000008")]
		public struct SYSTEMTIME
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000013")]
			internal ushort Year; //Field offset: 0x0
			[FieldOffset(Offset = "0x2")]
			[Token(Token = "0x4000014")]
			internal ushort Month; //Field offset: 0x2
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000015")]
			internal ushort DayOfWeek; //Field offset: 0x4
			[FieldOffset(Offset = "0x6")]
			[Token(Token = "0x4000016")]
			internal ushort Day; //Field offset: 0x6
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000017")]
			internal ushort Hour; //Field offset: 0x8
			[FieldOffset(Offset = "0xA")]
			[Token(Token = "0x4000018")]
			internal ushort Minute; //Field offset: 0xA
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000019")]
			internal ushort Second; //Field offset: 0xC
			[FieldOffset(Offset = "0xE")]
			[Token(Token = "0x400001A")]
			internal ushort Milliseconds; //Field offset: 0xE

			[Address(RVA = "0x12DE270", Offset = "0x12DD470", Length = "0x53")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckDaylightSavingTimeNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareStandardDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 5)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000029")]
			internal bool Equals(in SYSTEMTIME other) { }

		}

		[Token(Token = "0x2000009")]
		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[Token(Token = "0x200000B")]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000025")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000A")]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000024")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000C")]
			[UnsafeValueType]
			internal struct <TimeZoneKeyName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000026")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400001B")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400001C")]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x400001D")]
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x400001E")]
			internal int StandardBias; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400001F")]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			[FieldOffset(Offset = "0x98")]
			[Token(Token = "0x4000020")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			[FieldOffset(Offset = "0xA8")]
			[Token(Token = "0x4000021")]
			internal int DaylightBias; //Field offset: 0xA8
			[FieldOffset(Offset = "0xAC")]
			[FixedBuffer(typeof(char), 128)]
			[Token(Token = "0x4000022")]
			internal <TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; //Field offset: 0xAC
			[FieldOffset(Offset = "0x1AC")]
			[Token(Token = "0x4000023")]
			internal byte DynamicDaylightTimeDisabled; //Field offset: 0x1AC

			[Address(RVA = "0x12E7E30", Offset = "0x12E7030", Length = "0x11")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			[Token(Token = "0x600002A")]
			internal string GetTimeZoneKeyName() { }

		}

		[Token(Token = "0x200000D")]
		public struct TIME_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[Token(Token = "0x200000F")]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400002F")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000E")]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400002E")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000027")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x4000028")]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000029")]
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x400002A")]
			internal int StandardBias; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400002B")]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			[FieldOffset(Offset = "0x98")]
			[Token(Token = "0x400002C")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			[FieldOffset(Offset = "0xA8")]
			[Token(Token = "0x400002D")]
			internal int DaylightBias; //Field offset: 0xA8

			[Address(RVA = "0x12E7E70", Offset = "0x12E7070", Length = "0x118")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x600002B")]
			internal TIME_ZONE_INFORMATION(in TIME_DYNAMIC_ZONE_INFORMATION dtzi) { }

			[Address(RVA = "0x12E7E50", Offset = "0x12E7050", Length = "0xE")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			[Token(Token = "0x600002D")]
			internal string GetDaylightName() { }

			[Address(RVA = "0x12E7E60", Offset = "0x12E7060", Length = "0xE")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(string))]
			[Token(Token = "0x600002C")]
			internal string GetStandardName() { }

		}

		[Token(Token = "0x2000017")]
		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000057")]
			internal int dwFileAttributes; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000058")]
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000059")]
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x400005A")]
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x400005B")]
			internal uint nFileSizeHigh; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400005C")]
			internal uint nFileSizeLow; //Field offset: 0x20

			[Address(RVA = "0x12EC150", Offset = "0x12EB350", Length = "0x29")]
			[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x6000030")]
			internal void PopulateFrom(ref WIN32_FIND_DATA findData) { }

		}

		[Token(Token = "0x2000004")]
		public struct WIN32_FIND_DATA
		{
			[CompilerGenerated]
			[Token(Token = "0x2000006")]
			[UnsafeValueType]
			internal struct <_cAlternateFileName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400000D")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x2000005")]
			[UnsafeValueType]
			internal struct <_cFileName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400000C")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000002")]
			internal uint dwFileAttributes; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000003")]
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000004")]
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000005")]
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000006")]
			internal uint nFileSizeHigh; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000007")]
			internal uint nFileSizeLow; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000008")]
			internal uint dwReserved0; //Field offset: 0x24
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000009")]
			internal uint dwReserved1; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[FixedBuffer(typeof(char), 260)]
			[Token(Token = "0x400000A")]
			private <_cFileName>e__FixedBuffer _cFileName; //Field offset: 0x2C
			[FieldOffset(Offset = "0x234")]
			[FixedBuffer(typeof(char), 14)]
			[Token(Token = "0x400000B")]
			private <_cAlternateFileName>e__FixedBuffer _cAlternateFileName; //Field offset: 0x234

			[Token(Token = "0x17000001")]
			internal ReadOnlySpan<Char> cFileName
			{
				[Address(RVA = "0x12EC240", Offset = "0x12EB440", Length = "0x221")]
				[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
				[CallerCount(Count = 4)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[CallsUnknownMethods(Count = 2)]
				[Token(Token = "0x6000026")]
				internal get { } //Length: 545
			}

			[Address(RVA = "0x12EC240", Offset = "0x12EB440", Length = "0x221")]
			[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6000026")]
			internal ReadOnlySpan<Char> get_cFileName() { }

			[Address(RVA = "0x12EC180", Offset = "0x12EB380", Length = "0xB1")]
			[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
			[CalledBy(Type = typeof(FileSystem), Member = "UnityFindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000027")]
			internal void SetFileName(string fileName) { }

		}

		[Token(Token = "0x4000001")]
		private static bool useUWPFallback; //Field offset: 0x0

		[Address(RVA = "0x12D8440", Offset = "0x12D7640", Length = "0x84")]
		[CalledBy(Type = typeof(Kernel32), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(SafeFileHandle))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CloseDirectoryHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000B")]
		internal static bool CloseHandle(IntPtr handle) { }

		[Address(RVA = "0x12D88E0", Offset = "0x12D7AE0", Length = "0x1D7")]
		[CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityCopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(Kernel32), Member = "CopyFileUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		internal static int CopyFile(string src, string dst, bool failIfExists) { }

		[Address(RVA = "0x12D84D0", Offset = "0x12D76D0", Length = "0xAA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		internal static int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters) { }

		[Address(RVA = "0x12D8670", Offset = "0x12D7870", Length = "0x136")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000E")]
		internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

		[Address(RVA = "0x12D8580", Offset = "0x12D7780", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000D")]
		private static bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

		[Address(RVA = "0x12D87B0", Offset = "0x12D79B0", Length = "0x12E")]
		[CalledBy(Type = typeof(Kernel32), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(Win32Marshal), Member = "TryMakeWin32ErrorCodeFromHR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000002")]
		internal static int CopyFileUWP(string src, string dst, bool failIfExists) { }

		[Address(RVA = "0x12D8B60", Offset = "0x12D7D60", Length = "0xE1")]
		[CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityCreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000010")]
		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[Address(RVA = "0x12D8AC0", Offset = "0x12D7CC0", Length = "0x9F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600000F")]
		private static bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[Address(RVA = "0x12D8E50", Offset = "0x12D8050", Length = "0x18A")]
		[CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000012")]
		internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		[Address(RVA = "0x12D8D30", Offset = "0x12D7F30", Length = "0x116")]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityCreateFile_IntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000013")]
		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		[Address(RVA = "0x12D8C50", Offset = "0x12D7E50", Length = "0xE0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000011")]
		private static IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile) { }

		[Address(RVA = "0x12D9080", Offset = "0x12D8280", Length = "0xD1")]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityDeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000015")]
		internal static bool DeleteFile(string path) { }

		[Address(RVA = "0x12D8FE0", Offset = "0x12D81E0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000014")]
		private static bool DeleteFilePrivate(string path) { }

		[Address(RVA = "0x12D9200", Offset = "0x12D8400", Length = "0x10F")]
		[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000005")]
		internal static bool DeleteVolumeMountPoint(string mountPoint) { }

		[Address(RVA = "0x12D9160", Offset = "0x12D8360", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000004")]
		internal static bool DeleteVolumeMountPointPrivate(string mountPoint) { }

		[Address(RVA = "0x12D9430", Offset = "0x12D8630", Length = "0x12A")]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000017")]
		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data) { }

		[Address(RVA = "0x12D9310", Offset = "0x12D8510", Length = "0x115")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000016")]
		private static SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags) { }

		[Address(RVA = "0x12D9560", Offset = "0x12D8760", Length = "0xDA")]
		[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityFindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000018")]
		internal static bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData) { }

		[Address(RVA = "0x12D9640", Offset = "0x12D8840", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		private static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, Char* lpBuffer, int nSize, IntPtr[] arguments) { }

		[Address(RVA = "0x12D9730", Offset = "0x12D8930", Length = "0x84")]
		[CalledBy(Type = typeof(SafeLibraryHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000006")]
		internal static bool FreeLibrary(IntPtr hModule) { }

		[Address(RVA = "0x12D97C0", Offset = "0x12D89C0", Length = "0x81")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeZoneInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000009")]
		internal static uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation) { }

		[Address(RVA = "0x12D9900", Offset = "0x12D8B00", Length = "0xEF")]
		[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityGetFileAttributesEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001E")]
		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[Address(RVA = "0x12D9850", Offset = "0x12D8A50", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001D")]
		private static bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[Address(RVA = "0x12D99F0", Offset = "0x12D8BF0", Length = "0xAC")]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetDataUWP", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001F")]
		public static bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize) { }

		[Address(RVA = "0x12D9AA0", Offset = "0x12D8CA0", Length = "0x132")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000008")]
		internal static bool GetFileMUIPath(uint flags, string filePath, out StringBuilder language, ref int languageLength, out StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator) { }

		[Address(RVA = "0x12D9BE0", Offset = "0x12D8DE0", Length = "0x71")]
		[CalledBy(Type = typeof(DriveInfoInternal), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000020")]
		internal static int GetLogicalDrives() { }

		[Address(RVA = "0x12D9DC0", Offset = "0x12D8FC0", Length = "0xC")]
		[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(Win32Marshal), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[Token(Token = "0x600001A")]
		internal static string GetMessage(int errorCode) { }

		[Address(RVA = "0x12D9C60", Offset = "0x12D8E60", Length = "0x160")]
		[CalledBy(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(Kernel32), Member = "TryGetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(System.Span`1<System.Char>), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001B")]
		internal static string GetMessage(IntPtr moduleHandle, int errorCode) { }

		[Address(RVA = "0x12D9DD0", Offset = "0x12D8FD0", Length = "0x81")]
		[CalledBy(Type = "System.TimeZoneInfo+CachedData", Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = "System.TimeZoneInfo+CachedData", Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.TimeZoneInfo+OffsetAndRule")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000A")]
		internal static uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

		[Address(RVA = "0x12D9E60", Offset = "0x12D9060", Length = "0xEB")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		internal static SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags) { }

		[Address(RVA = "0x12DA010", Offset = "0x12D9210", Length = "0xFC")]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityMoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000022")]
		internal static bool MoveFile(string src, string dst) { }

		[Address(RVA = "0x12D9F50", Offset = "0x12D9150", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000021")]
		private static bool MoveFileExPrivate(string src, string dst, uint flags) { }

		[Address(RVA = "0x12DA1B0", Offset = "0x12D93B0", Length = "0xD1")]
		[CalledBy(Type = typeof(FileSystem), Member = "UnityRemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefixIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000024")]
		internal static bool RemoveDirectory(string path) { }

		[Address(RVA = "0x12DA110", Offset = "0x12D9310", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000023")]
		private static bool RemoveDirectoryPrivate(string path) { }

		[Address(RVA = "0x12DA290", Offset = "0x12D9490", Length = "0x91")]
		[CalledBy(Type = typeof(DisableMediaInsertionPrompt), Member = "Create", ReturnType = typeof(DisableMediaInsertionPrompt))]
		[CalledBy(Type = typeof(DisableMediaInsertionPrompt), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000025")]
		internal static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode) { }

		[Address(RVA = "0x12DA330", Offset = "0x12D9530", Length = "0x292")]
		[CalledBy(Type = typeof(Kernel32), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Span`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001C")]
		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<Char> buffer, out string errorMsg) { }

	}

	[Token(Token = "0x200001D")]
	public struct LongFileTime
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		internal long TicksSince1601; //Field offset: 0x0

	}

	[Token(Token = "0x200001F")]
	public class NtDll
	{
		[Token(Token = "0x2000026")]
		internal enum CreateDisposition
		{
			FILE_SUPERSEDE = 0,
			FILE_OPEN = 1,
			FILE_CREATE = 2,
			FILE_OPEN_IF = 3,
			FILE_OVERWRITE = 4,
			FILE_OVERWRITE_IF = 5,
		}

		[Token(Token = "0x2000027")]
		internal enum CreateOptions
		{
			FILE_DIRECTORY_FILE = 1,
			FILE_WRITE_THROUGH = 2,
			FILE_SEQUENTIAL_ONLY = 4,
			FILE_NO_INTERMEDIATE_BUFFERING = 8,
			FILE_SYNCHRONOUS_IO_ALERT = 16,
			FILE_SYNCHRONOUS_IO_NONALERT = 32,
			FILE_NON_DIRECTORY_FILE = 64,
			FILE_CREATE_TREE_CONNECTION = 128,
			FILE_COMPLETE_IF_OPLOCKED = 256,
			FILE_NO_EA_KNOWLEDGE = 512,
			FILE_RANDOM_ACCESS = 2048,
			FILE_DELETE_ON_CLOSE = 4096,
			FILE_OPEN_BY_FILE_ID = 8192,
			FILE_OPEN_FOR_BACKUP_INTENT = 16384,
			FILE_NO_COMPRESSION = 32768,
			FILE_OPEN_REQUIRING_OPLOCK = 65536,
			FILE_DISALLOW_EXCLUSIVE = 131072,
			FILE_SESSION_AWARE = 262144,
			FILE_RESERVE_OPFILTER = 1048576,
			FILE_OPEN_REPARSE_POINT = 2097152,
			FILE_OPEN_NO_RECALL = 4194304,
		}

		[Flags]
		[Token(Token = "0x2000028")]
		internal enum DesiredAccess
		{
			FILE_READ_DATA = 1,
			FILE_LIST_DIRECTORY = 1,
			FILE_WRITE_DATA = 2,
			FILE_ADD_FILE = 2,
			FILE_APPEND_DATA = 4,
			FILE_ADD_SUBDIRECTORY = 4,
			FILE_CREATE_PIPE_INSTANCE = 4,
			FILE_READ_EA = 8,
			FILE_WRITE_EA = 16,
			FILE_EXECUTE = 32,
			FILE_TRAVERSE = 32,
			FILE_DELETE_CHILD = 64,
			FILE_READ_ATTRIBUTES = 128,
			FILE_WRITE_ATTRIBUTES = 256,
			FILE_ALL_ACCESS = 983551,
			DELETE = 65536,
			READ_CONTROL = 131072,
			WRITE_DAC = 262144,
			WRITE_OWNER = 524288,
			SYNCHRONIZE = 1048576,
			STANDARD_RIGHTS_READ = 131072,
			STANDARD_RIGHTS_WRITE = 131072,
			STANDARD_RIGHTS_EXECUTE = 131072,
			FILE_GENERIC_READ = 2147483648,
			FILE_GENERIC_WRITE = 1073741824,
			FILE_GENERIC_EXECUTE = 536870912,
		}

		[Token(Token = "0x2000020")]
		internal struct FILE_FULL_DIR_INFORMATION
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006C")]
			public uint NextEntryOffset; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400006D")]
			public uint FileIndex; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400006E")]
			public LongFileTime CreationTime; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400006F")]
			public LongFileTime LastAccessTime; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000070")]
			public LongFileTime LastWriteTime; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000071")]
			public LongFileTime ChangeTime; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000072")]
			public long EndOfFile; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000073")]
			public long AllocationSize; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000074")]
			public FileAttributes FileAttributes; //Field offset: 0x38
			[FieldOffset(Offset = "0x3C")]
			[Token(Token = "0x4000075")]
			public uint FileNameLength; //Field offset: 0x3C
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000076")]
			public uint EaSize; //Field offset: 0x40
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000077")]
			private char _fileName; //Field offset: 0x44

			[Token(Token = "0x17000002")]
			public ReadOnlySpan<Char> FileName
			{
				[Address(RVA = "0x12D8230", Offset = "0x12D7430", Length = "0x67")]
				[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
				[CalledBy(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass3_0", Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass4_0", Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0", Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0", Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0", Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass8_0", Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
				[CallerCount(Count = 15)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
				[Token(Token = "0x6000037")]
				 get { } //Length: 103
			}

			[Address(RVA = "0x12D8230", Offset = "0x12D7430", Length = "0x67")]
			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
			[CalledBy(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass3_0", Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass4_0", Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0", Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0", Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0", Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass8_0", Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 15)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[Token(Token = "0x6000037")]
			public ReadOnlySpan<Char> get_FileName() { }

			[Address(RVA = "0x12D8210", Offset = "0x12D7410", Length = "0x12")]
			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Token(Token = "0x6000038")]
			public static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info) { }

		}

		[Token(Token = "0x2000021")]
		internal enum FILE_INFORMATION_CLASS
		{
			FileDirectoryInformation = 1,
			FileFullDirectoryInformation = 2,
			FileBothDirectoryInformation = 3,
			FileBasicInformation = 4,
			FileStandardInformation = 5,
			FileInternalInformation = 6,
			FileEaInformation = 7,
			FileAccessInformation = 8,
			FileNameInformation = 9,
			FileRenameInformation = 10,
			FileLinkInformation = 11,
			FileNamesInformation = 12,
			FileDispositionInformation = 13,
			FilePositionInformation = 14,
			FileFullEaInformation = 15,
			FileModeInformation = 16,
			FileAlignmentInformation = 17,
			FileAllInformation = 18,
			FileAllocationInformation = 19,
			FileEndOfFileInformation = 20,
			FileAlternateNameInformation = 21,
			FileStreamInformation = 22,
			FilePipeInformation = 23,
			FilePipeLocalInformation = 24,
			FilePipeRemoteInformation = 25,
			FileMailslotQueryInformation = 26,
			FileMailslotSetInformation = 27,
			FileCompressionInformation = 28,
			FileObjectIdInformation = 29,
			FileCompletionInformation = 30,
			FileMoveClusterInformation = 31,
			FileQuotaInformation = 32,
			FileReparsePointInformation = 33,
			FileNetworkOpenInformation = 34,
			FileAttributeTagInformation = 35,
			FileTrackingInformation = 36,
			FileIdBothDirectoryInformation = 37,
			FileIdFullDirectoryInformation = 38,
			FileValidDataLengthInformation = 39,
			FileShortNameInformation = 40,
			FileIoCompletionNotificationInformation = 41,
			FileIoStatusBlockRangeInformation = 42,
			FileIoPriorityHintInformation = 43,
			FileSfioReserveInformation = 44,
			FileSfioVolumeInformation = 45,
			FileHardLinkInformation = 46,
			FileProcessIdsUsingFileInformation = 47,
			FileNormalizedNameInformation = 48,
			FileNetworkPhysicalNameInformation = 49,
			FileIdGlobalTxDirectoryInformation = 50,
			FileIsRemoteDeviceInformation = 51,
			FileUnusedInformation = 52,
			FileNumaNodeInformation = 53,
			FileStandardLinkInformation = 54,
			FileRemoteProtocolInformation = 55,
			FileRenameInformationBypassAccessCheck = 56,
			FileLinkInformationBypassAccessCheck = 57,
			FileVolumeNameInformation = 58,
			FileIdInformation = 59,
			FileIdExtdDirectoryInformation = 60,
			FileReplaceCompletionInformation = 61,
			FileHardLinkFullIdInformation = 62,
			FileIdExtdBothDirectoryInformation = 63,
			FileDispositionInformationEx = 64,
			FileRenameInformationEx = 65,
			FileRenameInformationExBypassAccessCheck = 66,
			FileDesiredStorageClassInformation = 67,
			FileStatInformation = 68,
		}

		[Token(Token = "0x2000022")]
		internal struct IO_STATUS_BLOCK
		{
			[Token(Token = "0x2000023")]
			internal struct IO_STATUS
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x40000BF")]
				public uint Status; //Field offset: 0x0
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x40000C0")]
				public IntPtr Pointer; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000BD")]
			public IO_STATUS Status; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000BE")]
			public IntPtr Information; //Field offset: 0x8

		}

		[Token(Token = "0x2000024")]
		internal struct OBJECT_ATTRIBUTES
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000C1")]
			public uint Length; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000C2")]
			public IntPtr RootDirectory; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C3")]
			public UNICODE_STRING* ObjectName; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000C4")]
			public ObjectAttributes Attributes; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000C5")]
			public Void* SecurityDescriptor; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40000C6")]
			public Void* SecurityQualityOfService; //Field offset: 0x28

			[Address(RVA = "0x12DD6D0", Offset = "0x12DC8D0", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000039")]
			public OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory) { }

		}

		[Flags]
		[Token(Token = "0x2000025")]
		internal enum ObjectAttributes
		{
			OBJ_INHERIT = 2,
			OBJ_PERMANENT = 16,
			OBJ_EXCLUSIVE = 32,
			OBJ_CASE_INSENSITIVE = 64,
			OBJ_OPENIF = 128,
			OBJ_OPENLINK = 256,
		}


		[Address(RVA = "0x12DD1C0", Offset = "0x12DC3C0", Length = "0x280")]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		internal static ValueTuple<Int32, IntPtr> CreateFile(ReadOnlySpan<Char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = 2148532224, FileShare shareAccess = 7, FileAttributes fileAttributes = 0, CreateOptions createOptions = 32, ObjectAttributes objectAttributes = 64) { }

		[Address(RVA = "0x12DD450", Offset = "0x12DC650", Length = "0xF8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000033")]
		private static int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, Int64* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, Void* EaBuffer, uint EaLength) { }

		[Address(RVA = "0x12DD550", Offset = "0x12DC750", Length = "0xFE")]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetData", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000035")]
		public static int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan) { }

		[Address(RVA = "0x12DD650", Offset = "0x12DC850", Length = "0x76")]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "GetData", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		public static uint RtlNtStatusToDosError(int Status) { }

	}

	[Token(Token = "0x200001E")]
	public struct UNICODE_STRING
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		internal ushort Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400006A")]
		internal ushort MaximumLength; //Field offset: 0x2
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006B")]
		internal IntPtr Buffer; //Field offset: 0x8

	}

	[Token(Token = "0x200001A")]
	public class User32
	{

		[Address(RVA = "0x12EC020", Offset = "0x12EB220", Length = "0x12E")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000032")]
		internal static int LoadString(SafeLibraryHandle handle, int id, out StringBuilder buffer, int bufferLength) { }

	}


	[Address(RVA = "0x12D8330", Offset = "0x12D7530", Length = "0x10C")]
	[CalledBy(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(HashCode), Member = "GenerateGlobalSeed", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(HashCode), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Random), Member = "GenerateGlobalSeed", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Random), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	internal static void GetRandomBytes(Byte* buffer, int length) { }

}

