namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Capture>))]
[DefaultMember("Item")]
[Token(Token = "0x20000DC")]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection
{
	[Token(Token = "0x20000DD")]
	private sealed class Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000353")]
		private readonly CaptureCollection _collection; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000354")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170000CD")]
		public override Capture Current
		{
			[Address(RVA = "0x174F9E0", Offset = "0x174EBE0", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600049A")]
			 get { } //Length: 133
		}

		[Token(Token = "0x170000CE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x174F9E0", Offset = "0x174EBE0", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600049B")]
			private get { } //Length: 133
		}

		[Address(RVA = "0x140E2F0", Offset = "0x140D4F0", Length = "0x39")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000498")]
		internal Enumerator(CaptureCollection collection) { }

		[Address(RVA = "0x174F9E0", Offset = "0x174EBE0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600049A")]
		public override Capture get_Current() { }

		[Address(RVA = "0x174F900", Offset = "0x174EB00", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000499")]
		public override bool MoveNext() { }

		[Address(RVA = "0x174F9E0", Offset = "0x174EBE0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600049B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049D")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000350")]
	private readonly Group _group; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000351")]
	private readonly int _capcount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000352")]
	private Capture[] _captures; //Field offset: 0x20

	[Token(Token = "0x170000C7")]
	public override int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600047B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000C6")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600047A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C8")]
	public override Capture Item
	{
		[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
		[DeduplicatedMethod]
		[Token(Token = "0x600047C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C9")]
	public override object SyncRoot
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000481")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CA")]
	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item
	{
		[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000487")]
		private get { } //Length: 8
		[Address(RVA = "0x174E340", Offset = "0x174D540", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000488")]
		private set { } //Length: 78
	}

	[Token(Token = "0x170000CB")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000492")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000CC")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000495")]
		private get { } //Length: 8
		[Address(RVA = "0x174E730", Offset = "0x174D930", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000496")]
		private set { } //Length: 78
	}

	[Address(RVA = "0x174E780", Offset = "0x174D980", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000497")]
	internal CaptureCollection() { }

	[Address(RVA = "0x174D930", Offset = "0x174CB30", Length = "0x1C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000483")]
	public override void CopyTo(Capture[] array, int arrayIndex) { }

	[Address(RVA = "0x174DB00", Offset = "0x174CD00", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000482")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x174DBC0", Offset = "0x174CDC0", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000480")]
	internal void ForceInitialized() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047B")]
	public override int get_Count() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	public override Capture get_Item(int i) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000481")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x174DD60", Offset = "0x174CF60", Length = "0x249")]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Capture))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Capture[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Capture)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[CalledBy(Type = typeof(CaptureCollection), Member = "System.Collections.IList.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047F")]
	private Capture GetCapture(int i) { }

	[Address(RVA = "0x174DFB0", Offset = "0x174D1B0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047D")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x174E020", Offset = "0x174D220", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000489")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	[Address(RVA = "0x174E070", Offset = "0x174D270", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600048A")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	[Address(RVA = "0x174E0C0", Offset = "0x174D2C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x600048B")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	[Address(RVA = "0x174E120", Offset = "0x174D320", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600048C")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	[Address(RVA = "0x174E170", Offset = "0x174D370", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047E")]
	private override IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000487")]
	private override Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	[Address(RVA = "0x174E1E0", Offset = "0x174D3E0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000484")]
	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	[Address(RVA = "0x174E290", Offset = "0x174D490", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000485")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	[Address(RVA = "0x174E2E0", Offset = "0x174D4E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000486")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	[Address(RVA = "0x174E340", Offset = "0x174D540", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000488")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	[Address(RVA = "0x174E390", Offset = "0x174D590", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600048D")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x174E3E0", Offset = "0x174D5E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600048E")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x174E430", Offset = "0x174D630", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048F")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000492")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x174E330", Offset = "0x174D530", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureCollection), Member = "GetCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Capture))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000495")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x174E570", Offset = "0x174D770", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000490")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x174E640", Offset = "0x174D840", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000491")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x174E6E0", Offset = "0x174D8E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000493")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x174E690", Offset = "0x174D890", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000494")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x174E730", Offset = "0x174D930", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000496")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

