namespace System.Net;

[Token(Token = "0x2000230")]
internal static class NclUtilities
{
	[Token(Token = "0x4000901")]
	private static IPAddress[] _LocalAddresses; //Field offset: 0x0
	[Token(Token = "0x4000902")]
	private static object _LocalAddressesLock; //Field offset: 0x8
	[Token(Token = "0x4000903")]
	internal static string _LocalDomainName; //Field offset: 0x10

	[Token(Token = "0x170002C6")]
	internal static IPAddress[] LocalAddresses
	{
		[Address(RVA = "0x17DE970", Offset = "0x17DDB70", Length = "0x4FB")]
		[CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
		[Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000E0F")]
		internal get { } //Length: 1275
	}

	[Token(Token = "0x170002C7")]
	private static object LocalAddressesLock
	{
		[Address(RVA = "0x17DE8D0", Offset = "0x17DDAD0", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E10")]
		private get { } //Length: 155
	}

	[Address(RVA = "0x17DE970", Offset = "0x17DDB70", Length = "0x4FB")]
	[CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000E0F")]
	internal static IPAddress[] get_LocalAddresses() { }

	[Address(RVA = "0x17DE8D0", Offset = "0x17DDAD0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E10")]
	private static object get_LocalAddressesLock() { }

	[Address(RVA = "0x17DE770", Offset = "0x17DD970", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Token(Token = "0x6000E0E")]
	private static IPHostEntry GetLocalHost() { }

	[Address(RVA = "0x17DE790", Offset = "0x17DD990", Length = "0x84")]
	[CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
	[Calls(Type = typeof(IPAddress), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E0D")]
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	[Address(RVA = "0x17DE820", Offset = "0x17DDA20", Length = "0xA8")]
	[CalledBy(Type = "System.Net.TimerThread+TimerNode", Member = "Fire", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E0C")]
	internal static bool IsFatal(Exception exception) { }

}

