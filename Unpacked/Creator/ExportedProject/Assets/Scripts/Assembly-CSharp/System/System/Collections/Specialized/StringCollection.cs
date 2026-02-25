namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001A8")]
public class StringCollection : IList, ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000686")]
	private readonly ArrayList data; //Field offset: 0x10

	[Token(Token = "0x170001EA")]
	public override int Count
	{
		[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001E9")]
	public string Item
	{
		[Address(RVA = "0x17CBE40", Offset = "0x17CB040", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2B")]
		 get { } //Length: 79
		[Address(RVA = "0x17CBF60", Offset = "0x17CB160", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A2C")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170001ED")]
	public override object SyncRoot
	{
		[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A38")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001EC")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2F")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001EB")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2E")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001EE")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x17CBE40", Offset = "0x17CB040", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A39")]
		private get { } //Length: 79
		[Address(RVA = "0x17CBE90", Offset = "0x17CB090", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A3A")]
		private set { } //Length: 87
	}

	[Address(RVA = "0x17CBEF0", Offset = "0x17CB0F0", Length = "0x66")]
	[CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A42")]
	public StringCollection() { }

	[Address(RVA = "0x17CBBA0", Offset = "0x17CADA0", Length = "0x2A")]
	[CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A30")]
	public int Add(string value) { }

	[Address(RVA = "0x1659E90", Offset = "0x1659090", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A31")]
	public override void Clear() { }

	[Address(RVA = "0x143CD60", Offset = "0x143BF60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A32")]
	public bool Contains(string value) { }

	[Address(RVA = "0x143CBF0", Offset = "0x143BDF0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A33")]
	public void CopyTo(String[] array, int index) { }

	[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2D")]
	public override int get_Count() { }

	[Address(RVA = "0x17CBE40", Offset = "0x17CB040", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2B")]
	public string get_Item(int index) { }

	[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A38")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x143CD90", Offset = "0x143BF90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A34")]
	public int IndexOf(string value) { }

	[Address(RVA = "0x17CBBD0", Offset = "0x17CADD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A35")]
	public void Insert(int index, string value) { }

	[Address(RVA = "0x17CBC30", Offset = "0x17CAE30", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A36")]
	public void Remove(string value) { }

	[Address(RVA = "0x17CBC00", Offset = "0x17CAE00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A37")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x17CBF60", Offset = "0x17CB160", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A2C")]
	public void set_Item(int index, string value) { }

	[Address(RVA = "0x143CBF0", Offset = "0x143BDF0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A40")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x12BA770", Offset = "0x12B9970", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A41")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17CBC60", Offset = "0x17CAE60", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3B")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x17CBCC0", Offset = "0x17CAEC0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3C")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2F")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2E")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x17CBE40", Offset = "0x17CB040", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A39")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x17CBD20", Offset = "0x17CAF20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3D")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x17CBD80", Offset = "0x17CAF80", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3E")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x17CBDE0", Offset = "0x17CAFE0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3F")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x17CBE90", Offset = "0x17CB090", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A3A")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

