namespace RLD;

[Token(Token = "0x20002AD")]
public class ObjectSelectionChangedEventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A6C")]
	private ObjectSelectReason _selectReason; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6D")]
	private List<GameObject> _objectsWhichWereSelected; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6E")]
	private ObjectDeselectReason _deselectReason; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6F")]
	private List<GameObject> _objectsWhichWereDeselected; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A70")]
	private ObjectSelectionSnapshot _undoRedoSnapshot; //Field offset: 0x30

	[Token(Token = "0x17000879")]
	public ObjectDeselectReason DeselectReason
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001982")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700087A")]
	public int NumObjectsDeselected
	{
		[Address(RVA = "0x3EA0E0", Offset = "0x3E92E0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001983")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000877")]
	public int NumObjectsSelected
	{
		[Address(RVA = "0x3EA120", Offset = "0x3E9320", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001980")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700087B")]
	public List<GameObject> ObjectsWhichWereDeselected
	{
		[Address(RVA = "0x3EA160", Offset = "0x3E9360", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001984")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000878")]
	public List<GameObject> ObjectsWhichWereSelected
	{
		[Address(RVA = "0x3EA1D0", Offset = "0x3E93D0", Length = "0x68")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001981")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000876")]
	public ObjectSelectReason SelectReason
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600197F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700087C")]
	public ObjectSelectionSnapshot UndoRedoSnapshot
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001985")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x3E9F40", Offset = "0x3E9140", Length = "0x19F")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ForceDelete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveNullAndInactiveObjectRefs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001986")]
	public ObjectSelectionChangedEventArgs(ObjectSelectReason selectReason, List<GameObject> objectsWhichWereSelected, ObjectDeselectReason deselectReason, List<GameObject> objectsWhichWereDeselected, ObjectSelectionSnapshot undoRedoSnapshot = null) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001982")]
	public ObjectDeselectReason get_DeselectReason() { }

	[Address(RVA = "0x3EA0E0", Offset = "0x3E92E0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001983")]
	public int get_NumObjectsDeselected() { }

	[Address(RVA = "0x3EA120", Offset = "0x3E9320", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001980")]
	public int get_NumObjectsSelected() { }

	[Address(RVA = "0x3EA160", Offset = "0x3E9360", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001984")]
	public List<GameObject> get_ObjectsWhichWereDeselected() { }

	[Address(RVA = "0x3EA1D0", Offset = "0x3E93D0", Length = "0x68")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001981")]
	public List<GameObject> get_ObjectsWhichWereSelected() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600197F")]
	public ObjectSelectReason get_SelectReason() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001985")]
	public ObjectSelectionSnapshot get_UndoRedoSnapshot() { }

}

