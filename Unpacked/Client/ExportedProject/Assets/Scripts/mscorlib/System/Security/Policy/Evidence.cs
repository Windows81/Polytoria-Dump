namespace System.Security.Policy;

[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
[Token(Token = "0x20002D1")]
public sealed class Evidence : ICollection, IEnumerable
{
	[Token(Token = "0x20002D2")]
	private class EvidenceEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C56")]
		private IEnumerator currentEnum; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C57")]
		private IEnumerator hostEnum; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C58")]
		private IEnumerator assemblyEnum; //Field offset: 0x20

		[Token(Token = "0x1700025C")]
		public override object Current
		{
			[Address(RVA = "0x132A870", Offset = "0x1329A70", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600174B")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x132A810", Offset = "0x1329A10", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001748")]
		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum) { }

		[Address(RVA = "0x132A870", Offset = "0x1329A70", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600174B")]
		public override object get_Current() { }

		[Address(RVA = "0x132A6F0", Offset = "0x13298F0", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001749")]
		public override bool MoveNext() { }

		[Address(RVA = "0x132A780", Offset = "0x1329980", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600174A")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C53")]
	private bool _locked; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C54")]
	private ArrayList hostEvidenceList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C55")]
	private ArrayList assemblyEvidenceList; //Field offset: 0x20

	[Obsolete]
	[Token(Token = "0x1700025A")]
	public override int Count
	{
		[Address(RVA = "0x132AA60", Offset = "0x1329C60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001744")]
		 get { } //Length: 103
	}

	[Token(Token = "0x1700025B")]
	public override object SyncRoot
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001745")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001743")]
	public Evidence() { }

	[Address(RVA = "0x132A8C0", Offset = "0x1329AC0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete]
	[Token(Token = "0x6001746")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x132AA60", Offset = "0x1329C60", Length = "0x67")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001744")]
	public override int get_Count() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001745")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x132A990", Offset = "0x1329B90", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete]
	[Token(Token = "0x6001747")]
	public override IEnumerator GetEnumerator() { }

}

