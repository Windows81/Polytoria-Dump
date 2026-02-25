namespace RLD;

[DefaultMember("Item")]
[Token(Token = "0x2000219")]
public class SerializableDictionary : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x200021A")]
	private sealed class <>c
	{
		[Token(Token = "0x400081D")]
		public static readonly <>c<SerializedKeyType, SerializedValueType> <>9; //Field offset: 0x0
		[Token(Token = "0x400081E")]
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, Boolean> <>9__14_0; //Field offset: 0x0
		[Token(Token = "0x400081F")]
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, SerializedKeyType> <>9__14_1; //Field offset: 0x0
		[Token(Token = "0x4000820")]
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, SerializedValueType> <>9__14_2; //Field offset: 0x0

		[Address(RVA = "0x7FC070", Offset = "0x7FB270", Length = "0x11F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600146A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600146B")]
		public <>c() { }

		[Address(RVA = "0x7F9020", Offset = "0x7F8220", Length = "0x208")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600146C")]
		internal bool <RemoveNullKeys>b__14_0(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

		[Address(RVA = "0x7F9230", Offset = "0x7F8430", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600146D")]
		internal SerializedKeyType <RemoveNullKeys>b__14_1(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

		[Address(RVA = "0x7F92D0", Offset = "0x7F84D0", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600146E")]
		internal SerializedValueType <RemoveNullKeys>b__14_2(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400081A")]
	private Dictionary<SerializedKeyType, SerializedValueType> _dictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400081B")]
	private List<SerializedKeyType> _serializedKeys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400081C")]
	private List<SerializedValueType> _serializedValues; //Field offset: 0x0

	[Token(Token = "0x17000678")]
	public Dictionary<SerializedKeyType, SerializedValueType> Dictionary
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600145F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000679")]
	public SerializedValueType Item
	{
		[Address(RVA = "0xF113B0", Offset = "0xF105B0", Length = "0x132")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001460")]
		 get { } //Length: 306
		[Address(RVA = "0xF114F0", Offset = "0xF106F0", Length = "0x170")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001461")]
		 set { } //Length: 368
	}

	[Address(RVA = "0xF11280", Offset = "0xF10480", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001469")]
	public SerializableDictionary`2() { }

	[Address(RVA = "0xF0FE80", Offset = "0xF0F080", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001465")]
	public void Add(SerializedKeyType key, SerializedValueType value) { }

	[Address(RVA = "0xF10000", Offset = "0xF0F200", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001464")]
	public void Clear() { }

	[Address(RVA = "0xF10030", Offset = "0xF0F230", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001466")]
	public bool ContainsKey(SerializedKeyType key) { }

	[Address(RVA = "0xF10120", Offset = "0xF0F320", Length = "0x444")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180F08950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001467")]
	public void Copy(SerializableDictionary<SerializedKeyType, SerializedValueType> other) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600145F")]
	public Dictionary<SerializedKeyType, SerializedValueType> get_Dictionary() { }

	[Address(RVA = "0xF113B0", Offset = "0xF105B0", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001460")]
	public SerializedValueType get_Item(SerializedKeyType index) { }

	[Address(RVA = "0xF10570", Offset = "0xF0F770", Length = "0x322")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001463")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0xF108A0", Offset = "0xF0FAA0", Length = "0x4B2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180F08950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001462")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0xF10D60", Offset = "0xF0FF60", Length = "0x518")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001468")]
	public void RemoveNullKeys() { }

	[Address(RVA = "0xF114F0", Offset = "0xF106F0", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001461")]
	public void set_Item(SerializedKeyType index, SerializedValueType value) { }

}

