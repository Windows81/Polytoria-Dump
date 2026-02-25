namespace RLD;

[Token(Token = "0x20002B0")]
public class ObjectSelectionSnapshot
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A73")]
	private List<GameObject> _snapshotObjects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A74")]
	private ObjectSelectionGizmosSnapshot _gizmosSnapshot; //Field offset: 0x18

	[Token(Token = "0x17000881")]
	public ObjectSelectionGizmosSnapshot GizmosSnapshot
	{
		[Address(RVA = "0x3EBD80", Offset = "0x3EAF80", Length = "0x6F")]
		[CalledBy(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600198D")]
		 get { } //Length: 111
	}

	[Token(Token = "0x1700087F")]
	public int NumObjects
	{
		[Address(RVA = "0x3EBDF0", Offset = "0x3EAFF0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600198B")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000880")]
	public List<GameObject> SnapshotObjects
	{
		[Address(RVA = "0x3EBE30", Offset = "0x3EB030", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600198C")]
		 get { } //Length: 104
	}

	[Address(RVA = "0x3EBB80", Offset = "0x3EAD80", Length = "0xAC")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeleteSelectedObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600198E")]
	public ObjectSelectionSnapshot() { }

	[Address(RVA = "0x3EBC30", Offset = "0x3EAE30", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "get_GizmosSnapshot", ReturnType = typeof(ObjectSelectionGizmosSnapshot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600198F")]
	public ObjectSelectionSnapshot(ObjectSelectionSnapshot copy) { }

	[Address(RVA = "0x3EBD80", Offset = "0x3EAF80", Length = "0x6F")]
	[CalledBy(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600198D")]
	public ObjectSelectionGizmosSnapshot get_GizmosSnapshot() { }

	[Address(RVA = "0x3EBDF0", Offset = "0x3EAFF0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600198B")]
	public int get_NumObjects() { }

	[Address(RVA = "0x3EBE30", Offset = "0x3EB030", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600198C")]
	public List<GameObject> get_SnapshotObjects() { }

	[Address(RVA = "0x3EB9A0", Offset = "0x3EABA0", Length = "0x1D7")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeleteSelectedObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Token(Token = "0x6001990")]
	public void Snapshot() { }

}

