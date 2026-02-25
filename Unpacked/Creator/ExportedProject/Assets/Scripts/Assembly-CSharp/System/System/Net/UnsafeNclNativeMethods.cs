namespace System.Net;

[Token(Token = "0x2000270")]
internal static class UnsafeNclNativeMethods
{
	[Token(Token = "0x2000271")]
	public static class HttpApi
	{
		[Token(Token = "0x2000272")]
		public static class HTTP_REQUEST_HEADER_ID
		{
			[Token(Token = "0x4000A26")]
			private static String[] m_Strings; //Field offset: 0x0

			[Address(RVA = "0x17F3E20", Offset = "0x17F3020", Length = "0x7E6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x6000FBC")]
			private static HTTP_REQUEST_HEADER_ID() { }

			[Address(RVA = "0x17F3DB0", Offset = "0x17F2FB0", Length = "0x6E")]
			[CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x6000FBB")]
			internal static string ToString(int position) { }

		}

		[Token(Token = "0x4000A25")]
		private static String[] m_Strings; //Field offset: 0x0

		[Address(RVA = "0x17F4610", Offset = "0x17F3810", Length = "0x5D6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FBA")]
		private static HttpApi() { }

	}

	[Token(Token = "0x2000273")]
	public static class SecureStringHelper
	{

		[Address(RVA = "0x17FBF30", Offset = "0x17FB130", Length = "0x9F")]
		[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SystemNetworkCredential), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SystemNetworkCredential), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecureString), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000FBE")]
		internal static SecureString CreateSecureString(string plainString) { }

		[Address(RVA = "0x17FBFD0", Offset = "0x17FB1D0", Length = "0x107")]
		[CalledBy(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(NetworkCredential), Member = "InternalGetPassword", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Marshal), Member = "SecureStringToGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817E8200")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000FBD")]
		internal static string CreateString(SecureString secureString) { }

	}


}

