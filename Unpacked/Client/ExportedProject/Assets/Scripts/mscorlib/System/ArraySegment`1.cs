namespace System;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x20000B8")]
public struct ArraySegment : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Token(Token = "0x20000B9")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AC")]
		private readonly T[] _array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AD")]
		private readonly int _start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AE")]
		private readonly int _end; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AF")]
		private int _current; //Field offset: 0x0

		[Token(Token = "0x1700005C")]
		public override T Current
		{
			[Address(RVA = "0xB084D0", Offset = "0xB076D0", Length = "0x4E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumNotStarted", ReturnType = typeof(void))]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumEnded", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000431")]
			 get { } //Length: 78
		}

		[Token(Token = "0x1700005D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB06EE0", Offset = "0xB060E0", Length = "0x9A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumNotStarted", ReturnType = typeof(void))]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumEnded", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000432")]
			private get { } //Length: 154
		}

		[Address(RVA = "0xB074E0", Offset = "0xB066E0", Length = "0xF8")]
		[CalledBy(Type = typeof(ArraySegment`1), Member = "GetEnumerator", ReturnType = "System.ArraySegment`1<T>+Enumerator<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600042F")]
		internal Enumerator(ArraySegment<T> arraySegment) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000434")]
		public override void Dispose() { }

		[Address(RVA = "0xB084D0", Offset = "0xB076D0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumNotStarted", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumEnded", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000431")]
		public override T get_Current() { }

		[Address(RVA = "0xB00C00", Offset = "0xAFFE00", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000430")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB06EE0", Offset = "0xB060E0", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumNotStarted", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumEnded", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000432")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB05430", Offset = "0xB04630", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000433")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x40002A8")]
	private static readonly ArraySegment<T> <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A9")]
	private readonly T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AA")]
	private readonly int _offset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AB")]
	private readonly int _count; //Field offset: 0x0

	[Token(Token = "0x17000056")]
	public T[] Array
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000414")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000058")]
	public override int Count
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000416")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	public static ArraySegment<T> Empty
	{
		[Address(RVA = "0xAFA3B0", Offset = "0xAF95B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000411")]
		 get { } //Length: 158
	}

	[Token(Token = "0x17000057")]
	public int Offset
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000415")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005B")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000426")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000059")]
	private override T System.Collections.Generic.IList<T>.Item
	{
		[Address(RVA = "0xAF9930", Offset = "0xAF8B30", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000420")]
		private get { } //Length: 194
		[Address(RVA = "0xAF9A00", Offset = "0xAF8C00", Length = "0xD0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000421")]
		private set { } //Length: 208
	}

	[Token(Token = "0x1700005A")]
	private override T System.Collections.Generic.IReadOnlyList<T>.Item
	{
		[Address(RVA = "0xAF9930", Offset = "0xAF8B30", Length = "0xC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000425")]
		private get { } //Length: 194
	}

	[Address(RVA = "0xAFA180", Offset = "0xAF9380", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042E")]
	private static ArraySegment`1() { }

	[Address(RVA = "0xAFA340", Offset = "0xAF9540", Length = "0x59")]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "OnSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SpawnMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LatencySimulation", Member = "ClientLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LatencySimulation", Member = "ServerLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "Generate", ReturnType = "Mirror.Transports.Encryption.EncryptionCredentials")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Mirror.Transports.Encryption.EncryptionCredentials")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000412")]
	public ArraySegment`1(T[] array) { }

	[Address(RVA = "0xAFA2D0", Offset = "0xAF94D0", Length = "0x6F")]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArraySegmentCtorValidationFailedExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000413")]
	public ArraySegment`1(T[] array, int offset, int count) { }

	[Address(RVA = "0xAF8490", Offset = "0xAF7690", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000419")]
	public override void CopyTo(T[] destination, int destinationIndex) { }

	[Address(RVA = "0xAF8640", Offset = "0xAF7840", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600041B")]
	public bool Equals(ArraySegment<T> obj) { }

	[Address(RVA = "0xAF8660", Offset = "0xAF7860", Length = "0x144")]
	[CalledBy(Type = typeof(Array), Member = "InternalArray__ICollection_Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Array), Member = "InternalArray__IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ObjectEqualityComparer`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectEqualityComparer`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ObjectEqualityComparer`1), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600041A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000414")]
	public T[] get_Array() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000416")]
	public override int get_Count() { }

	[Address(RVA = "0xAFA3B0", Offset = "0xAF95B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000411")]
	public static ArraySegment<T> get_Empty() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000415")]
	public int get_Offset() { }

	[Address(RVA = "0xAF8A50", Offset = "0xAF7C50", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000417")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xAF8B30", Offset = "0xAF7D30", Length = "0x9C")]
	[CalledBy(Type = typeof(ObjectEqualityComparer`1), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000418")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xAFA450", Offset = "0xAF9650", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600041D")]
	public static bool op_Equality(ArraySegment<T> a, ArraySegment<T> b) { }

	[Address(RVA = "0xAFA5D0", Offset = "0xAF97D0", Length = "0x7B")]
	[CalledBy(Type = "Mirror.Unbatcher", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderPool+<>c", Member = "<.cctor>b__6_0", ReturnType = "Mirror.NetworkReaderPooled")]
	[CalledBy(Type = "Mirror.NetworkReaderPool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "Mirror.NetworkReaderPooled")]
	[CalledBy(Type = "Mirror.NetworkReaderPooled", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600041F")]
	public static ArraySegment<T> op_Implicit(T[] array) { }

	[Address(RVA = "0xAFA650", Offset = "0xAF9850", Length = "0x126")]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Telepathy.EventType", "System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "TryDequeue", ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600041E")]
	public static bool op_Inequality(ArraySegment<T> a, ArraySegment<T> b) { }

	[Address(RVA = "0xAF8D10", Offset = "0xAF7F10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000427")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0xAF8D10", Offset = "0xAF7F10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000428")]
	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	[Address(RVA = "0xAF8E10", Offset = "0xAF8010", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000429")]
	private override bool System.Collections.Generic.ICollection<T>.Contains(T item) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000426")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xAF9100", Offset = "0xAF8300", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600042A")]
	private override bool System.Collections.Generic.ICollection<T>.Remove(T item) { }

	[Address(RVA = "0xAF9120", Offset = "0xAF8320", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007BE70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042B")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xAF9930", Offset = "0xAF8B30", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000420")]
	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	[Address(RVA = "0xAF92F0", Offset = "0xAF84F0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000422")]
	private override int System.Collections.Generic.IList<T>.IndexOf(T item) { }

	[Address(RVA = "0xAF8D10", Offset = "0xAF7F10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000423")]
	private override void System.Collections.Generic.IList<T>.Insert(int index, T item) { }

	[Address(RVA = "0xAF8D10", Offset = "0xAF7F10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000424")]
	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	[Address(RVA = "0xAF9A00", Offset = "0xAF8C00", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000421")]
	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	[Address(RVA = "0xAF9930", Offset = "0xAF8B30", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000425")]
	private override T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }

	[Address(RVA = "0xAF9120", Offset = "0xAF8320", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007BE70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x600042C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xAF9DC0", Offset = "0xAF8FC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600042D")]
	private void ThrowInvalidOperationIfDefault() { }

	[Address(RVA = "0xAF9FA0", Offset = "0xAF91A0", Length = "0x1DC")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientWebGl", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600041C")]
	public T[] ToArray() { }

}

