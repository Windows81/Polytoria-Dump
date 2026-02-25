namespace RLD;

[Token(Token = "0x20002A9")]
public class ObjectSelectionSettings : Settings
{
	[CompilerGenerated]
	[Token(Token = "0x20002AA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A52")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000A53")]
		public static Predicate<GameObject> <>9__45_0; //Field offset: 0x8

		[Address(RVA = "0x3FF8E0", Offset = "0x3FEAE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600197C")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600197D")]
		public <>c() { }

		[Address(RVA = "0x3FF670", Offset = "0x3FE870", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600197E")]
		internal bool <RemoveNullObjectRefs>b__45_0(GameObject item) { }

	}

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A47")]
	private MultiSelectOverlapMode _multiSelectOverlapMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000A48")]
	private GameObjectType _selectableObjectTypes; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A49")]
	private int _selectableLayers; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000A4A")]
	private int _duplicatableLayers; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000A4B")]
	private int _deletableLayers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A4C")]
	private HashSet<GameObject> _nonSelectableObjects; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A4D")]
	private HashSet<Camera> _nonSelectableCameras; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000A4E")]
	private bool _canClickSelect; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	[Token(Token = "0x4000A4F")]
	private bool _enableCyclicalClickSelect; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	[Token(Token = "0x4000A50")]
	private bool _canMultiSelect; //Field offset: 0x52
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000A51")]
	private int _minMultiSelectSize; //Field offset: 0x54

	[Token(Token = "0x1700086F")]
	public bool CanClickSelect
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600195F")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001960")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000871")]
	public bool CanMultiSelect
	{
		[Address(RVA = "0x3EB930", Offset = "0x3EAB30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001963")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB970", Offset = "0x3EAB70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001964")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000874")]
	public int DeletableLayers
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001969")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600196A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000873")]
	public int DuplicatableLayers
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001967")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001968")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000870")]
	public bool EnableCyclicalClickSelect
	{
		[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001961")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001962")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000875")]
	public int MinMultiSelectSize
	{
		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x600196B")]
		 get { } //Length: 4
		[Address(RVA = "0x3EB990", Offset = "0x3EAB90", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600196C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700086E")]
	public MultiSelectOverlapMode MultiSelectOverlapMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600195D")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600195E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000872")]
	public int SelectableLayers
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001965")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001966")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3EB830", Offset = "0x3EAA30", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600197B")]
	public ObjectSelectionSettings() { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600195F")]
	public bool get_CanClickSelect() { }

	[Address(RVA = "0x3EB930", Offset = "0x3EAB30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001963")]
	public bool get_CanMultiSelect() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001969")]
	public int get_DeletableLayers() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001967")]
	public int get_DuplicatableLayers() { }

	[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001961")]
	public bool get_EnableCyclicalClickSelect() { }

	[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x600196B")]
	public int get_MinMultiSelectSize() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600195D")]
	public MultiSelectOverlapMode get_MultiSelectOverlapMode() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001965")]
	public int get_SelectableLayers() { }

	[Address(RVA = "0x3EB020", Offset = "0x3EA220", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600196D")]
	public bool IsCameraSelectable(Camera camera) { }

	[Address(RVA = "0x3EB080", Offset = "0x3EA280", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600197A")]
	public bool IsObjectLayerDeletable(int objectLayer) { }

	[Address(RVA = "0x3EB090", Offset = "0x3EA290", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001978")]
	public bool IsObjectLayerDuplicatable(int objectLayer) { }

	[Address(RVA = "0x3EB0A0", Offset = "0x3EA2A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001972")]
	public bool IsObjectLayerSelectable(int objectLayer) { }

	[Address(RVA = "0x3EB0B0", Offset = "0x3EA2B0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001974")]
	public bool IsObjectSelectable(GameObject gameObject) { }

	[Address(RVA = "0x3EB150", Offset = "0x3EA350", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001970")]
	public bool IsObjectTypeSelectable(GameObjectType gameObjectType) { }

	[Address(RVA = "0x3EB160", Offset = "0x3EA360", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001977")]
	public void RemoveNullObjectRefs() { }

	[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001960")]
	public void set_CanClickSelect(bool value) { }

	[Address(RVA = "0x3EB970", Offset = "0x3EAB70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001964")]
	public void set_CanMultiSelect(bool value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600196A")]
	public void set_DeletableLayers(int value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001968")]
	public void set_DuplicatableLayers(int value) { }

	[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001962")]
	public void set_EnableCyclicalClickSelect(bool value) { }

	[Address(RVA = "0x3EB990", Offset = "0x3EAB90", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600196C")]
	public void set_MinMultiSelectSize(int value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600195E")]
	public void set_MultiSelectOverlapMode(MultiSelectOverlapMode value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001966")]
	public void set_SelectableLayers(int value) { }

	[Address(RVA = "0x3EB280", Offset = "0x3EA480", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600196F")]
	public void SetCameraCollectionSelectable(List<Camera> cameraCollection, bool areSelectable) { }

	[Address(RVA = "0x3EB440", Offset = "0x3EA640", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600196E")]
	public void SetCameraSelectable(Camera camera, bool isSelectable) { }

	[Address(RVA = "0x3EB510", Offset = "0x3EA710", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001976")]
	public void SetObjectCollectionSelectable(List<GameObject> gameObjectCollection, bool areSelectable) { }

	[Address(RVA = "0x3EB6D0", Offset = "0x3EA8D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "ClearLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LayerEx), Member = "SetLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6001979")]
	public void SetObjectLayerDuplicatable(int objectLayer, bool isDuplicatable) { }

	[Address(RVA = "0x3EB710", Offset = "0x3EA910", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayerEx), Member = "ClearLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LayerEx), Member = "SetLayerBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6001973")]
	public void SetObjectLayerSelectable(int objectLayer, bool isSelectable) { }

	[Address(RVA = "0x3EB750", Offset = "0x3EA950", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001975")]
	public void SetObjectSelectable(GameObject gameObject, bool isSelectable) { }

	[Address(RVA = "0x3EB820", Offset = "0x3EAA20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001971")]
	public void SetObjectTypeSelectable(GameObjectType gameObjectType, bool isSelectable) { }

}

