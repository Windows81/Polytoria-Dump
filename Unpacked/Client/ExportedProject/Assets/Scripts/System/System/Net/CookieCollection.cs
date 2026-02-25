namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000261")]
public class CookieCollection : ICollection, IEnumerable
{
	[Token(Token = "0x2000263")]
	private class CookieCollectionEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009F0")]
		private CookieCollection m_cookies; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009F1")]
		private int m_count; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009F2")]
		private int m_index; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009F3")]
		private int m_version; //Field offset: 0x20

		[Token(Token = "0x1700031E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x17CDE80", Offset = "0x17CD080", Length = "0x1D0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6000F44")]
			private get { } //Length: 464
		}

		[Address(RVA = "0x17CE060", Offset = "0x17CD260", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F43")]
		internal CookieCollectionEnumerator(CookieCollection cookies) { }

		[Address(RVA = "0x17CDE80", Offset = "0x17CD080", Length = "0x1D0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000F44")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x17CDDD0", Offset = "0x17CCFD0", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F45")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x17941B0", Offset = "0x17933B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F46")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000262")]
	public enum Stamp
	{
		Check = 0,
		Set = 1,
		SetToUnused = 2,
		SetToMaxUsed = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E6")]
	internal int m_version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009E7")]
	private ArrayList m_list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009E8")]
	private DateTime m_TimeStamp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009E9")]
	private bool m_has_other_versions; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[OptionalField]
	[Token(Token = "0x40009EA")]
	private bool m_IsReadOnly; //Field offset: 0x29

	[Token(Token = "0x1700031B")]
	public override int Count
	{
		[Address(RVA = "0x17C6610", Offset = "0x17C5810", Length = "0x2A")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031D")]
	internal bool IsOtherVersionSeen
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700031A")]
	public Cookie Item
	{
		[Address(RVA = "0x17CECF0", Offset = "0x17CDEF0", Length = "0xF3")]
		[CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000F37")]
		 get { } //Length: 243
	}

	[Token(Token = "0x1700031C")]
	public override object SyncRoot
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x17CEC40", Offset = "0x17CDE40", Length = "0xA5")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F36")]
	public CookieCollection() { }

	[Address(RVA = "0x17CE0D0", Offset = "0x17CD2D0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookieCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F38")]
	public void Add(Cookie cookie) { }

	[Address(RVA = "0x17CE1A0", Offset = "0x17CD3A0", Length = "0x339")]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookieCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000F39")]
	public void Add(CookieCollection cookies) { }

	[Address(RVA = "0x17CE4E0", Offset = "0x17CD6E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F3C")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x17C6610", Offset = "0x17C5810", Length = "0x2A")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F3A")]
	public override int get_Count() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F3E")]
	internal bool get_IsOtherVersionSeen() { }

	[Address(RVA = "0x17CECF0", Offset = "0x17CDEF0", Length = "0xF3")]
	[CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F37")]
	public Cookie get_Item(int index) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F3B")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x17CE510", Offset = "0x17CD710", Length = "0x96")]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F42")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x17CE5B0", Offset = "0x17CD7B0", Length = "0x21B")]
	[CalledBy(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F40")]
	internal int IndexOf(Cookie cookie) { }

	[Address(RVA = "0x17CE7D0", Offset = "0x17CD9D0", Length = "0x33D")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000F3F")]
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	[Address(RVA = "0x17CEB10", Offset = "0x17CDD10", Length = "0x2A")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F41")]
	internal void RemoveAt(int idx) { }

	[Address(RVA = "0x17CEB40", Offset = "0x17CDD40", Length = "0xF1")]
	[CalledBy(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000F3D")]
	internal DateTime TimeStamp(Stamp how) { }

}

