namespace RLD;

[Token(Token = "0x2000270")]
public class RTUndoRedo : MonoSingleton<RTUndoRedo>
{
	[Token(Token = "0x2000271")]
	private class ActionGroup
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009A2")]
		public List<IUndoRedoAction> Actions; //Field offset: 0x10

		[Address(RVA = "0x5A6750", Offset = "0x5A5950", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001883")]
		public ActionGroup(IUndoRedoAction action) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000999")]
	private UndoStartHandler UndoStart; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400099A")]
	private UndoEndHandler UndoEnd; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400099B")]
	private RedoStartHandler RedoStart; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400099C")]
	private RedoEndHandler RedoEnd; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400099D")]
	private CanUndoRedoHandler CanUndoRedo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400099E")]
	private bool _isEnabled; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400099F")]
	private int _actionLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009A0")]
	private List<ActionGroup> _actionGroupStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009A1")]
	private int _stackPointer; //Field offset: 0x58

	[Token(Token = "0x14000039")]
	public event CanUndoRedoHandler CanUndoRedo
	{
		[Address(RVA = "0x5BE0F0", Offset = "0x5BD2F0", Length = "0x9E")]
		[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001875")]
		 add { } //Length: 158
		[Address(RVA = "0x5BE410", Offset = "0x5BD610", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001876")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000038")]
	public event RedoEndHandler RedoEnd
	{
		[Address(RVA = "0x5BE190", Offset = "0x5BD390", Length = "0x9E")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001873")]
		 add { } //Length: 158
		[Address(RVA = "0x5BE4B0", Offset = "0x5BD6B0", Length = "0x9E")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001874")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000037")]
	public event RedoStartHandler RedoStart
	{
		[Address(RVA = "0x5BE230", Offset = "0x5BD430", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001871")]
		 add { } //Length: 158
		[Address(RVA = "0x5BE550", Offset = "0x5BD750", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001872")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000036")]
	public event UndoEndHandler UndoEnd
	{
		[Address(RVA = "0x5BE2D0", Offset = "0x5BD4D0", Length = "0x9E")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600186F")]
		 add { } //Length: 158
		[Address(RVA = "0x5BE5F0", Offset = "0x5BD7F0", Length = "0x9E")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001870")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000035")]
	public event UndoStartHandler UndoStart
	{
		[Address(RVA = "0x5BE370", Offset = "0x5BD570", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600186D")]
		 add { } //Length: 158
		[Address(RVA = "0x5BE690", Offset = "0x5BD890", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600186E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700082A")]
	public int ActionLimit
	{
		[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001878")]
		 get { } //Length: 4
		[Address(RVA = "0x5BE730", Offset = "0x5BD930", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RTUndoRedo), Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001879")]
		 set { } //Length: 105
	}

	[Token(Token = "0x17000829")]
	public bool IsEnabled
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001877")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BE030", Offset = "0x5BD230", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001882")]
	public RTUndoRedo() { }

	[Address(RVA = "0x5BE0F0", Offset = "0x5BD2F0", Length = "0x9E")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001875")]
	public void add_CanUndoRedo(CanUndoRedoHandler value) { }

	[Address(RVA = "0x5BE190", Offset = "0x5BD390", Length = "0x9E")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001873")]
	public void add_RedoEnd(RedoEndHandler value) { }

	[Address(RVA = "0x5BE230", Offset = "0x5BD430", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001871")]
	public void add_RedoStart(RedoStartHandler value) { }

	[Address(RVA = "0x5BE2D0", Offset = "0x5BD4D0", Length = "0x9E")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600186F")]
	public void add_UndoEnd(UndoEndHandler value) { }

	[Address(RVA = "0x5BE370", Offset = "0x5BD570", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600186D")]
	public void add_UndoStart(UndoStartHandler value) { }

	[Address(RVA = "0x5BD520", Offset = "0x5BC720", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTUndoRedo), Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600187B")]
	public void ClearActions() { }

	[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001878")]
	public int get_ActionLimit() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001877")]
	public bool get_IsEnabled() { }

	[Address(RVA = "0x5BD580", Offset = "0x5BC780", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTUndoRedo), Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001881")]
	private void OnValidate() { }

	[Address(RVA = "0x5BD5F0", Offset = "0x5BC7F0", Length = "0x23D")]
	[CalledBy(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoDragEnd), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostObjectSpawnAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostGizmoTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuplicateObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeleteSelectedObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTUndoRedo), Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600187C")]
	public void RecordAction(IUndoRedoAction action) { }

	[Address(RVA = "0x5BD830", Offset = "0x5BCA30", Length = "0x22A")]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "Redo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600187F")]
	public void Redo() { }

	[Address(RVA = "0x5BE410", Offset = "0x5BD610", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001876")]
	public void remove_CanUndoRedo(CanUndoRedoHandler value) { }

	[Address(RVA = "0x5BE4B0", Offset = "0x5BD6B0", Length = "0x9E")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001874")]
	public void remove_RedoEnd(RedoEndHandler value) { }

	[Address(RVA = "0x5BE550", Offset = "0x5BD750", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001872")]
	public void remove_RedoStart(RedoStartHandler value) { }

	[Address(RVA = "0x5BE5F0", Offset = "0x5BD7F0", Length = "0x9E")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001870")]
	public void remove_UndoEnd(UndoEndHandler value) { }

	[Address(RVA = "0x5BE690", Offset = "0x5BD890", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600186E")]
	public void remove_UndoStart(UndoStartHandler value) { }

	[Address(RVA = "0x5BDA60", Offset = "0x5BCC60", Length = "0x298")]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "set_ActionLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "ClearActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001880")]
	private void RemoveGroups(int startIndex, int count) { }

	[Address(RVA = "0x5BE730", Offset = "0x5BD930", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTUndoRedo), Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001879")]
	public void set_ActionLimit(int value) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600187A")]
	public void SetEnabled(bool isEnabled) { }

	[Address(RVA = "0x5BDD00", Offset = "0x5BCF00", Length = "0x20A")]
	[CalledBy(Type = typeof(RTUndoRedo), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "Undo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600187E")]
	public void Undo() { }

	[Address(RVA = "0x5BDF10", Offset = "0x5BD110", Length = "0x112")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RTUndoRedo), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "Redo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x600187D")]
	public void Update_SystemCall() { }

}

