namespace RLD;

[Token(Token = "0x200006E")]
public class GizmoCollectionEnabledStateSnapshot
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000192")]
	private Dictionary<Gizmo, Boolean> _gizmoToState; //Field offset: 0x10

	[Address(RVA = "0x3CD2B0", Offset = "0x3CC4B0", Length = "0x77")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036B")]
	public GizmoCollectionEnabledStateSnapshot() { }

	[Address(RVA = "0x3CCF20", Offset = "0x3CC120", Length = "0x169")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionManipSessionEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionManipSession)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionEnabled", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Boolean>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600036A")]
	public void Apply() { }

	[Address(RVA = "0x3CD090", Offset = "0x3CC290", Length = "0x214")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionManipSessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionManipSession)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionDisabled", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000369")]
	public void Snapshot(IEnumerable<Gizmo> gizmos) { }

}

