namespace RLD;

[Token(Token = "0x20002C7")]
public class RTObjectSelectionGizmos : MonoSingleton<RTObjectSelectionGizmos>, IObjectCollectionGizmoController
{
	[CompilerGenerated]
	[Token(Token = "0x20002C9")]
	private sealed class <>c__DisplayClass101_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE3")]
		public Gizmo gizmo; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A7B")]
		public <>c__DisplayClass101_0() { }

		[Address(RVA = "0x3E56D0", Offset = "0x3E48D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A7C")]
		internal bool <GetGizmoId>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002CA")]
	private sealed class <>c__DisplayClass102_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE4")]
		public int id; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A7D")]
		public <>c__DisplayClass102_0() { }

		[Address(RVA = "0x3FF6C0", Offset = "0x3FE8C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A7E")]
		internal bool <GetTransformGizmoById>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002CB")]
	private sealed class <>c__DisplayClass119_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE5")]
		public int gizmoId; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A7F")]
		public <>c__DisplayClass119_0() { }

		[Address(RVA = "0x3FF6C0", Offset = "0x3FE8C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A80")]
		internal bool <IsGizmoRegistered>b__0(ObjectSelectionGizmo item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002CC")]
	private sealed class <>c__DisplayClass120_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE6")]
		public Gizmo gizmo; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A81")]
		public <>c__DisplayClass120_0() { }

		[Address(RVA = "0x3E56D0", Offset = "0x3E48D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A82")]
		internal bool <IsGizmoRegistered>b__0(ObjectSelectionGizmo item) { }

	}

	[Token(Token = "0x20002C8")]
	private class ObjectSelectionGizmo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000ADD")]
		private int _id; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000ADE")]
		private Gizmo _gizmo; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000ADF")]
		private BoxGizmo _boxScaleGizmo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AE0")]
		private ObjectTransformGizmo _transformGizmo; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AE1")]
		private ObjectExtrudeGizmo _extrudeGizmo; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AE2")]
		private bool _isUsable; //Field offset: 0x38

		[Token(Token = "0x170008B9")]
		public BoxGizmo BoxScaleGizmo
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A72")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170008BD")]
		public ObjectExtrudeGizmo ExtrudeGizmo
		{
			[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
			[CallerCount(Count = 27)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A76")]
			 get { } //Length: 95
		}

		[Token(Token = "0x170008B8")]
		public Gizmo Gizmo
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A71")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170008B7")]
		public int Id
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A70")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170008BA")]
		public bool IsBoxScaleGizmo
		{
			[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
			[CallerCount(Count = 16)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A73")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170008BE")]
		public bool IsExtrudeGizmo
		{
			[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A77")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170008BC")]
		public bool IsTransformGizmo
		{
			[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A75")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170008BF")]
		public bool IsUsable
		{
			[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A78")]
			 get { } //Length: 5
			[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A79")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170008BB")]
		public ObjectTransformGizmo TransformGizmo
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001A74")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x3EA3E0", Offset = "0x3E95E0", Length = "0xE7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Gizmo), Member = "GetFirstBehaviourOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001A7A")]
		public ObjectSelectionGizmo(int id, Gizmo gizmo) { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A72")]
		public BoxGizmo get_BoxScaleGizmo() { }

		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A76")]
		public ObjectExtrudeGizmo get_ExtrudeGizmo() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A71")]
		public Gizmo get_Gizmo() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A70")]
		public int get_Id() { }

		[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A73")]
		public bool get_IsBoxScaleGizmo() { }

		[Address(RVA = "0x3EA4D0", Offset = "0x3E96D0", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A77")]
		public bool get_IsExtrudeGizmo() { }

		[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A75")]
		public bool get_IsTransformGizmo() { }

		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A78")]
		public bool get_IsUsable() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A74")]
		public ObjectTransformGizmo get_TransformGizmo() { }

		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A79")]
		public void set_IsUsable(bool value) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000AB8")]
	private EditorToolbar _mainToolbar; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000AB9")]
	private UniversalGizmoConfig _universalGizmoConfig; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ABA")]
	private GizmoCollectionEnabledStateSnapshot _gizmosEnabledStateSnapshot; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000ABB")]
	private List<ObjectSelectionGizmo> _allGizmos; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000ABC")]
	private List<ObjectTransformGizmo> _objectTransformGizmos; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000ABD")]
	private int _workGizmoId; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ABE")]
	private ObjectSelectionGizmo _workGizmo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ABF")]
	private bool _areGizmosVisible; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000AC0")]
	private GizmoSpace _transformSpace; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AC1")]
	private GameObject _pivotObject; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AC2")]
	private IEnumerable<GameObject> _targetObjectCollection; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000AC3")]
	private ObjectSelectionGizmosHotkeys _hotkeys; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000AC4")]
	private MoveGizmoSettings2D _moveGizmoSettings2D; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000AC5")]
	private MoveGizmoSettings3D _moveGizmoSettings3D; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000AC6")]
	private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000AC7")]
	private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000AC8")]
	private MoveGizmoHotkeys _moveGizmoHotkeys; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000AC9")]
	private ObjectTransformGizmoSettings _objectMoveGizmoSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000ACA")]
	private RotationGizmoSettings3D _rotationGizmoSettings3D; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000ACB")]
	private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000ACC")]
	private RotationGizmoHotkeys _rotationGizmoHotkeys; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000ACD")]
	private ObjectTransformGizmoSettings _objectRotationGizmoSettings; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000ACE")]
	private ScaleGizmoSettings3D _scaleGizmoSettings3D; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000ACF")]
	private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000AD0")]
	private ScaleGizmoHotkeys _scaleGizmoHotkeys; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000AD1")]
	private ObjectTransformGizmoSettings _objectScaleGizmoSettings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000AD2")]
	private UniversalGizmoSettings2D _universalGizmoSettings2D; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000AD3")]
	private UniversalGizmoSettings3D _universalGizmoSettings3D; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000AD4")]
	private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000AD5")]
	private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000AD6")]
	private UniversalGizmoHotkeys _universalGizmoHotkeys; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000AD7")]
	private ObjectTransformGizmoSettings _objectUniversalGizmoSettings; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000AD8")]
	private BoxGizmoSettings3D _boxScaleGizmoSettings3D; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000AD9")]
	private BoxGizmoLookAndFeel3D _boxScaleGizmoLookAndFeel3D; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000ADA")]
	private BoxGizmoHotkeys _boxScaleGizmoHotkeys; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000ADB")]
	private ObjectExtrudeGizmoLookAndFeel3D _extrudeGizmoLookAndFeel3D; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x4000ADC")]
	private ObjectExtrudeGizmoHotkeys _extrudeGizmoHotkeys; //Field offset: 0x138

	[Token(Token = "0x1700089A")]
	public bool AreGizmosVisible
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A38")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170008B4")]
	public BoxGizmoHotkeys BoxScaleGizmoHotkeys
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A52")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B3")]
	public BoxGizmoLookAndFeel3D BoxScaleGizmoLookAndFeel3D
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A51")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B2")]
	public BoxGizmoSettings3D BoxScaleGizmoSettings3D
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A50")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B5")]
	public ObjectExtrudeGizmoLookAndFeel3D ExtrudeGizmoLookAndFeel3D
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A53")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B6")]
	public ObjectExtrudeGizmoHotkeys ExtrudeGozmoHotkeys
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A54")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700089D")]
	public ObjectSelectionGizmosHotkeys Hotkeys
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A3B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170008A2")]
	public MoveGizmoHotkeys MoveGizmoHotkeys
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A40")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A0")]
	public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A3E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A1")]
	public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A3F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700089E")]
	public MoveGizmoSettings2D MoveGizmoSettings2D
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A3C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700089F")]
	public MoveGizmoSettings3D MoveGizmoSettings3D
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A3D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A3")]
	public ObjectTransformGizmoSettings ObjectMoveGizmoSettings
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A41")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A7")]
	public ObjectTransformGizmoSettings ObjectRotationGizmoSettings
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A45")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AB")]
	public ObjectTransformGizmoSettings ObjectScaleGizmoSettings
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A49")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B1")]
	public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700089B")]
	public GameObject PivotObject
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A39")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170008A6")]
	public RotationGizmoHotkeys RotationGizmoHotkeys
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A44")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A5")]
	public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A43")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A4")]
	public RotationGizmoSettings3D RotationGizmoSettings3D
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A42")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AA")]
	public ScaleGizmoHotkeys ScaleGizmoHotkeys
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A48")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A9")]
	public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A47")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008A8")]
	public ScaleGizmoSettings3D ScaleGizmoSettings3D
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A46")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008B0")]
	public UniversalGizmoHotkeys UniversalGizmoHotkeys
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AE")]
	public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D
	{
		[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AF")]
	public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AC")]
	public UniversalGizmoSettings2D UniversalGizmoSettings2D
	{
		[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170008AD")]
	public UniversalGizmoSettings3D UniversalGizmoSettings3D
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A4B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700089C")]
	public Gizmo WorkGizmo
	{
		[Address(RVA = "0x3F58E0", Offset = "0x3F4AE0", Length = "0x1B")]
		[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A3A")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x3F4B50", Offset = "0x3F3D50", Length = "0xCD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UniversalGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmoSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EditorToolbarTab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EditorToolbar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EditorToolbarTab[]), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionGizmosHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoSettings2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A6F")]
	public RTObjectSelectionGizmos() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A38")]
	public bool get_AreGizmosVisible() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A52")]
	public BoxGizmoHotkeys get_BoxScaleGizmoHotkeys() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A51")]
	public BoxGizmoLookAndFeel3D get_BoxScaleGizmoLookAndFeel3D() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A50")]
	public BoxGizmoSettings3D get_BoxScaleGizmoSettings3D() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A53")]
	public ObjectExtrudeGizmoLookAndFeel3D get_ExtrudeGizmoLookAndFeel3D() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A54")]
	public ObjectExtrudeGizmoHotkeys get_ExtrudeGozmoHotkeys() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A3B")]
	public ObjectSelectionGizmosHotkeys get_Hotkeys() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A40")]
	public MoveGizmoHotkeys get_MoveGizmoHotkeys() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A3E")]
	public MoveGizmoLookAndFeel2D get_MoveGizmoLookAndFeel2D() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A3F")]
	public MoveGizmoLookAndFeel3D get_MoveGizmoLookAndFeel3D() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A3C")]
	public MoveGizmoSettings2D get_MoveGizmoSettings2D() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A3D")]
	public MoveGizmoSettings3D get_MoveGizmoSettings3D() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A41")]
	public ObjectTransformGizmoSettings get_ObjectMoveGizmoSettings() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A45")]
	public ObjectTransformGizmoSettings get_ObjectRotationGizmoSettings() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A49")]
	public ObjectTransformGizmoSettings get_ObjectScaleGizmoSettings() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4F")]
	public ObjectTransformGizmoSettings get_ObjectUniversalGizmoSettings() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A39")]
	public GameObject get_PivotObject() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A44")]
	public RotationGizmoHotkeys get_RotationGizmoHotkeys() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A43")]
	public RotationGizmoLookAndFeel3D get_RotationGizmoLookAndFeel3D() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A42")]
	public RotationGizmoSettings3D get_RotationGizmoSettings3D() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A48")]
	public ScaleGizmoHotkeys get_ScaleGizmoHotkeys() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A47")]
	public ScaleGizmoLookAndFeel3D get_ScaleGizmoLookAndFeel3D() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A46")]
	public ScaleGizmoSettings3D get_ScaleGizmoSettings3D() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4E")]
	public UniversalGizmoHotkeys get_UniversalGizmoHotkeys() { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4C")]
	public UniversalGizmoLookAndFeel2D get_UniversalGizmoLookAndFeel2D() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4D")]
	public UniversalGizmoLookAndFeel3D get_UniversalGizmoLookAndFeel3D() { }

	[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4A")]
	public UniversalGizmoSettings2D get_UniversalGizmoSettings2D() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A4B")]
	public UniversalGizmoSettings3D get_UniversalGizmoSettings3D() { }

	[Address(RVA = "0x3F58E0", Offset = "0x3F4AE0", Length = "0x1B")]
	[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A3A")]
	public Gizmo get_WorkGizmo() { }

	[Address(RVA = "0x3F1EE0", Offset = "0x3F10E0", Length = "0x23A")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetGizmosVisisble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionManipSessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionManipSession)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionDisabled", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A59")]
	public List<Gizmo> GetAllGizmos() { }

	[Address(RVA = "0x3F2120", Offset = "0x3F1320", Length = "0x4E")]
	[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "OnAppInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "IsGizmoRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A58")]
	public Gizmo GetGizmoById(int gizmoId) { }

	[Address(RVA = "0x3F2170", Offset = "0x3F1370", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A5A")]
	public int GetGizmoId(Gizmo gizmo) { }

	[Address(RVA = "0x3F22A0", Offset = "0x3F14A0", Length = "0x136")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A6A")]
	private ObjectSelectionGizmo GetObjectSelectionGizmo(Gizmo gizmo) { }

	[Address(RVA = "0x3F23E0", Offset = "0x3F15E0", Length = "0x135")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetGizmoUsable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "GetGizmoById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Gizmo))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetWorkGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A6B")]
	private ObjectSelectionGizmo GetObjectSelectionGizmo(int id) { }

	[Address(RVA = "0x3F2520", Offset = "0x3F1720", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Gizmo), Member = "GetFirstBehaviourOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A5B")]
	public ObjectTransformGizmo GetTransformGizmoById(int id) { }

	[Address(RVA = "0x3F2660", Offset = "0x3F1860", Length = "0xAF8")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectBoxScaleGizmo", ReturnType = typeof(BoxGizmo))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectExtrudeGizmo", ReturnType = typeof(ObjectExtrudeGizmo))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectTransformPivot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A56")]
	public void Initialize_SystemCall() { }

	[Address(RVA = "0x3F3160", Offset = "0x3F2360", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A6D")]
	private bool IsGizmoRegistered(Gizmo gizmo) { }

	[Address(RVA = "0x3F3250", Offset = "0x3F2450", Length = "0xE1")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "GetGizmoById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Gizmo))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A6C")]
	private bool IsGizmoRegistered(int gizmoId) { }

	[Address(RVA = "0x3F3340", Offset = "0x3F2540", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "SetTargetHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPositionAndRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A63")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x3F33E0", Offset = "0x3F25E0", Length = "0x239")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_NumSelectedObjects", ReturnType = typeof(int))]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = "get_ObjectsWhichWereSelected", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "get_GizmosSnapshot", ReturnType = typeof(ObjectSelectionGizmosSnapshot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A61")]
	private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	[Address(RVA = "0x3F3620", Offset = "0x3F2820", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetAllGizmos", ReturnType = typeof(System.Collections.Generic.List`1<RLD.Gizmo>))]
	[Calls(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = "Snapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<RLD.Gizmo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A69")]
	private void OnObjectSelectionDisabled() { }

	[Address(RVA = "0x3F3760", Offset = "0x3F2960", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A68")]
	private void OnObjectSelectionEnabled() { }

	[Address(RVA = "0x3F3780", Offset = "0x3F2980", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetAllGizmos", ReturnType = typeof(System.Collections.Generic.List`1<RLD.Gizmo>))]
	[Calls(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = "Snapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<RLD.Gizmo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A65")]
	private void OnObjectSelectionManipSessionBegin(ObjectSelectionManipSession manipSession) { }

	[Address(RVA = "0x3F3760", Offset = "0x3F2960", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCollectionEnabledStateSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A66")]
	private void OnObjectSelectionManipSessionEnd(ObjectSelectionManipSession manipSession) { }

	[Address(RVA = "0x3F38C0", Offset = "0x3F2AC0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "RefreshPositionAndRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A67")]
	private void OnObjectSelectionRotated() { }

	[Address(RVA = "0x3F3A10", Offset = "0x3F2C10", Length = "0x217")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "SetGizmosVisisble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTargetPivotObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "SetTargetHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A64")]
	private void OnTargetObjectGroupUpdated() { }

	[Address(RVA = "0x3F3C30", Offset = "0x3F2E30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[Token(Token = "0x6001A62")]
	private void OnUndoRedo(IUndoRedoAction action) { }

	[Address(RVA = "0x3F3C40", Offset = "0x3F2E40", Length = "0x6DC")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MoveGizmo), Member = "SetVertexSnapTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = "set_SharedHotkeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoHotkeys)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "set_SharedSettings2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoSettings2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "set_SharedLookAndFeel2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "SetMvVertexSnapTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectExtrudeGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalGizmoSettings3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoSettings3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "set_SharedLookAndFeel2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "set_SharedSettings2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "GetFirstBehaviourOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "IsGizmoRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001A6E")]
	private bool RegisterGizmo(int gizmoId, Gizmo gizmo) { }

	[Address(RVA = "0x3F4390", Offset = "0x3F3590", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetAllGizmos", ReturnType = typeof(System.Collections.Generic.List`1<RLD.Gizmo>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "OnTargetObjectGroupUpdated", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A5F")]
	public void SetGizmosVisisble(bool visible) { }

	[Address(RVA = "0x3F4320", Offset = "0x3F3520", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A57")]
	public void SetGizmoUsable(int gizmoId, bool isUsable) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A55")]
	public override void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection) { }

	[Address(RVA = "0x3F44F0", Offset = "0x3F36F0", Length = "0x113")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectTransformPivot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A5C")]
	public void SetTransformPivot(GizmoObjectTransformPivot transformPivot) { }

	[Address(RVA = "0x3F4610", Offset = "0x3F3810", Length = "0x142")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = "SetExtrudeSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A5D")]
	public void SetTransformSpace(GizmoSpace transformSpace) { }

	[Address(RVA = "0x3F4760", Offset = "0x3F3960", Length = "0xF2")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetActiveGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A5E")]
	public void SetWorkGizmo(int gizmoId) { }

	[Address(RVA = "0x3F4860", Offset = "0x3F3A60", Length = "0x2E9")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetObjectSelectionGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ObjectSelectionGizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A60")]
	public void Update_SystemCall() { }

}

