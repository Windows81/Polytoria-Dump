namespace RLD;

[Token(Token = "0x2000163")]
public static class LayerEx
{

	[Address(RVA = "0x542C30", Offset = "0x541E30", Length = "0x9")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapSettings), Member = "SetLayerSnapDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmoSettings), Member = "SetLayerTransformable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "SetObjectLayerSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "SetObjectLayerDuplicatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF7")]
	public static int ClearLayerBit(int layerBits, int layerNumber) { }

	[Address(RVA = "0x542C40", Offset = "0x541E40", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LayerMask), Member = "LayerToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FF9")]
	public static List<String> GetAllLayerNames() { }

	[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FF4")]
	public static int GetMaxLayer() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FF3")]
	public static int GetMinLayer() { }

	[Address(RVA = "0x542D00", Offset = "0x541F00", Length = "0x17")]
	[CalledBy(Type = typeof(SceneRaycastFilter), Member = "<FilterHits>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Duplicate", ReturnType = typeof(ObjectSelectionDuplicationResult))]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "CanUseObjectAsSnapDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GatherDestinationObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapSettings), Member = "IsLayerSnapDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetTransformableParentObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[CalledBy(Type = typeof(ObjectTransformGizmoSettings), Member = "IsLayerTransformable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SceneOverlapFilter), Member = "<FilterOverlaps>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "CanSelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "RLD.RTObjectSelection+SelectRestrictFlags", typeof(ObjectSelectReason)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "IdentifyGrabSurface", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Object2ObjectSnap+<>c__DisplayClass14_0", Member = "<CalculateSnapResult>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "IsObjectLayerSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "IsObjectLayerDuplicatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "IsObjectLayerDeletable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF5")]
	public static bool IsLayerBitSet(int layerBits, int layerNumber) { }

	[Address(RVA = "0x542D20", Offset = "0x541F20", Length = "0xE")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF8")]
	public static bool IsLayerValid(int layerNumber) { }

	[Address(RVA = "0x542D30", Offset = "0x541F30", Length = "0x9")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapSettings), Member = "SetLayerSnapDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmoSettings), Member = "SetLayerTransformable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "SetObjectLayerSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionSettings), Member = "SetObjectLayerDuplicatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FF6")]
	public static int SetLayerBit(int layerBits, int layerNumber) { }

}

