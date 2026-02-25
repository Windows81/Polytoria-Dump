namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000266")]
internal class PathList
{
	[Token(Token = "0x2000267")]
	private class PathListComparer : IComparer
	{
		[Token(Token = "0x40009FE")]
		internal static readonly PathListComparer StaticInstance; //Field offset: 0x0

		[Address(RVA = "0x17FB9D0", Offset = "0x17FABD0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F61")]
		private static PathListComparer() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F60")]
		public PathListComparer() { }

		[Address(RVA = "0x17FB860", Offset = "0x17FAA60", Length = "0x16A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CookieParser), Member = "CheckQuoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F5F")]
		private override int System.Collections.IComparer.Compare(object ol, object or) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009FD")]
	private SortedList m_list; //Field offset: 0x10

	[Token(Token = "0x17000321")]
	public int Count
	{
		[Address(RVA = "0x13935F0", Offset = "0x13927F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F58")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000323")]
	public object Item
	{
		[Address(RVA = "0x17FBE10", Offset = "0x17FB010", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F5B")]
		 get { } //Length: 42
		[Address(RVA = "0x17FBE40", Offset = "0x17FB040", Length = "0xE7")]
		[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000F5C")]
		 set { } //Length: 231
	}

	[Token(Token = "0x17000324")]
	public object SyncRoot
	{
		[Address(RVA = "0x144FC40", Offset = "0x144EE40", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000322")]
	public ICollection Values
	{
		[Address(RVA = "0x1659CB0", Offset = "0x1658EB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5A")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x17FBD50", Offset = "0x17FAF50", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortedList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortedList)}, ReturnType = typeof(SortedList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F57")]
	public PathList() { }

	[Address(RVA = "0x13935F0", Offset = "0x13927F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F58")]
	public int get_Count() { }

	[Address(RVA = "0x17FBE10", Offset = "0x17FB010", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F5B")]
	public object get_Item(string s) { }

	[Address(RVA = "0x144FC40", Offset = "0x144EE40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F5E")]
	public object get_SyncRoot() { }

	[Address(RVA = "0x1659CB0", Offset = "0x1658EB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F5A")]
	public ICollection get_Values() { }

	[Address(RVA = "0x17FBA40", Offset = "0x17FAC40", Length = "0x302")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000F59")]
	public int GetCookiesCount() { }

	[Address(RVA = "0x143D0D0", Offset = "0x143C2D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F5D")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x17FBE40", Offset = "0x17FB040", Length = "0xE7")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F5C")]
	public void set_Item(string s, object value) { }

}

