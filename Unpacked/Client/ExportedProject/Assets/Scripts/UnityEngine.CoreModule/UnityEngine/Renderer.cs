namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000B5")]
[UsedByNativeCode]
public class Renderer : Component
{

	[Token(Token = "0x170000A8")]
	public Bounds bounds
	{
		[Address(RVA = "0x193D620", Offset = "0x193C820", Length = "0x94")]
		[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.BoundsCalculationMethod"}, ReturnType = typeof(Bounds))]
		[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "AdjustLoadedObjectBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GroupSelection", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		[Token(Token = "0x60003D4")]
		 get { } //Length: 148
	}

	[Token(Token = "0x170000AA")]
	public bool enabled
	{
		[Address(RVA = "0x193D700", Offset = "0x193C900", Length = "0x76")]
		[CalledBy(Type = "RLD.SceneTree", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.Object2ObjectSnapData", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E0")]
		 get { } //Length: 118
		[Address(RVA = "0x193DC50", Offset = "0x193CE50", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnShow", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "OnShow", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "OnHide", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "OnShow", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnHide", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "OnShow", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "OnHide", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFirstPersonRendering", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "_Enable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "OnHide", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E1")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000B2")]
	public bool isPartOfStaticBatch
	{
		[Address(RVA = "0x193D7C0", Offset = "0x193C9C0", Length = "0x76")]
		[CalledBy(Type = "Mirror.HexSpatialHash2DInterestManagement+<>c", Member = "<OnSpawned>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.HexSpatialHash3DInterestManagement+<>c", Member = "<OnSpawned>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsPartOfStaticBatch")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000AB")]
	public bool isVisible
	{
		[Address(RVA = "0x193D880", Offset = "0x193CA80", Length = "0x76")]
		[CalledBy(Type = "RLD.SceneTree", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsVisibleInScene")]
		[Token(Token = "0x60003E2")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000A9")]
	public Bounds localBounds
	{
		[Address(RVA = "0x193DD30", Offset = "0x193CF30", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SetLocalAABB")]
		[Token(Token = "0x60003D5")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000B4")]
	public Material material
	{
		[Address(RVA = "0x193CF30", Offset = "0x193C130", Length = "0x90")]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 144
		[Address(RVA = "0x193D510", Offset = "0x193C710", Length = "0xBA")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EF")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170000B3")]
	public Material[] materials
	{
		[Address(RVA = "0x193CE70", Offset = "0x193C070", Length = "0x76")]
		[CallerCount(Count = 77)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EC")]
		 get { } //Length: 118
		[Address(RVA = "0x193DDC0", Offset = "0x193CFC0", Length = "0x8")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Renderer), Member = "SetMaterialArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003ED")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170000AD")]
	public bool receiveShadows
	{
		[Address(RVA = "0x193DE20", Offset = "0x193D020", Length = "0x86")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E4")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000AC")]
	public ShadowCastingMode shadowCastingMode
	{
		[Address(RVA = "0x193DEF0", Offset = "0x193D0F0", Length = "0x83")]
		[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E3")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000B5")]
	public Material sharedMaterial
	{
		[Address(RVA = "0x193D0E0", Offset = "0x193C2E0", Length = "0x90")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F0")]
		 get { } //Length: 144
		[Address(RVA = "0x193D510", Offset = "0x193C710", Length = "0xBA")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F1")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170000B6")]
	public Material[] sharedMaterials
	{
		[Address(RVA = "0x193DDC0", Offset = "0x193CFC0", Length = "0x8")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Renderer), Member = "SetMaterialArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F2")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170000B0")]
	internal int sortingGroupID
	{
		[Address(RVA = "0x193D940", Offset = "0x193CB40", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E9")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170000B1")]
	internal int sortingGroupOrder
	{
		[Address(RVA = "0x193DA00", Offset = "0x193CC00", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003EA")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170000AE")]
	public int sortingLayerID
	{
		[Address(RVA = "0x193DAC0", Offset = "0x193CCC0", Length = "0x76")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 118
		[Address(RVA = "0x193DFC0", Offset = "0x193D1C0", Length = "0x83")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E6")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000AF")]
	public int sortingOrder
	{
		[Address(RVA = "0x193DB80", Offset = "0x193CD80", Length = "0x76")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingOrder", ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 118
		[Address(RVA = "0x193E090", Offset = "0x193D290", Length = "0x83")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E8")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F3")]
	public Renderer() { }

	[Address(RVA = "0x193D620", Offset = "0x193C820", Length = "0x94")]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.BoundsCalculationMethod"}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "AdjustLoadedObjectBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	[Token(Token = "0x60003D4")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x193D5D0", Offset = "0x193C7D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F4")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x193D700", Offset = "0x193C900", Length = "0x76")]
	[CalledBy(Type = "RLD.SceneTree", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Object2ObjectSnapData", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E0")]
	public bool get_enabled() { }

	[Address(RVA = "0x193D6C0", Offset = "0x193C8C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FD")]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193D7C0", Offset = "0x193C9C0", Length = "0x76")]
	[CalledBy(Type = "Mirror.HexSpatialHash2DInterestManagement+<>c", Member = "<OnSpawned>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.HexSpatialHash3DInterestManagement+<>c", Member = "<OnSpawned>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsPartOfStaticBatch")]
	[Token(Token = "0x60003EB")]
	public bool get_isPartOfStaticBatch() { }

	[Address(RVA = "0x193D780", Offset = "0x193C980", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000408")]
	private static bool get_isPartOfStaticBatch_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193D880", Offset = "0x193CA80", Length = "0x76")]
	[CalledBy(Type = "RLD.SceneTree", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "RLD.SceneRaycastPrecision", "System.Collections.Generic.List`1<GameObjectRayHit>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsVisibleInScene")]
	[Token(Token = "0x60003E2")]
	public bool get_isVisible() { }

	[Address(RVA = "0x193D840", Offset = "0x193CA40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FF")]
	private static bool get_isVisible_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193CF30", Offset = "0x193C130", Length = "0x90")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EE")]
	public Material get_material() { }

	[Address(RVA = "0x193CE70", Offset = "0x193C070", Length = "0x76")]
	[CallerCount(Count = 77)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EC")]
	public Material[] get_materials() { }

	[Address(RVA = "0x193D0E0", Offset = "0x193C2E0", Length = "0x90")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F0")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x193D940", Offset = "0x193CB40", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E9")]
	internal int get_sortingGroupID() { }

	[Address(RVA = "0x193D900", Offset = "0x193CB00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000406")]
	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193DA00", Offset = "0x193CC00", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003EA")]
	internal int get_sortingGroupOrder() { }

	[Address(RVA = "0x193D9C0", Offset = "0x193CBC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000407")]
	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193DAC0", Offset = "0x193CCC0", Length = "0x76")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E5")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x193DA80", Offset = "0x193CC80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000402")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193DB80", Offset = "0x193CD80", Length = "0x76")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E7")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x193DB40", Offset = "0x193CD40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000404")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193CF30", Offset = "0x193C130", Length = "0x90")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	[Token(Token = "0x60003D6")]
	private Material GetMaterial() { }

	[Address(RVA = "0x193CEF0", Offset = "0x193C0F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F6")]
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193CE70", Offset = "0x193C070", Length = "0x76")]
	[CallerCount(Count = 77)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	[Token(Token = "0x60003D9")]
	private Material[] GetMaterialArray() { }

	[Address(RVA = "0x193CE30", Offset = "0x193C030", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F9")]
	private static Material[] GetMaterialArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193CFD0", Offset = "0x193C1D0", Length = "0xC7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DF")]
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[Address(RVA = "0x193D0E0", Offset = "0x193C2E0", Length = "0x90")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	[Token(Token = "0x60003D7")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x193D0A0", Offset = "0x193C2A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F7")]
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193CFD0", Offset = "0x193C1D0", Length = "0xC7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	[Token(Token = "0x60003DD")]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[Address(RVA = "0x193D180", Offset = "0x193C380", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FC")]
	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	[Address(RVA = "0x193D220", Offset = "0x193C420", Length = "0x9C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	[Token(Token = "0x60003DC")]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[Address(RVA = "0x193D1D0", Offset = "0x193C3D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FB")]
	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	[Address(RVA = "0x193DC50", Offset = "0x193CE50", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "_Enable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFirstPersonRendering", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "EnableRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.InterestManagementBase", Member = "SetHostVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "OnShow", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E1")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x193DC00", Offset = "0x193CE00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FE")]
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x193DD30", Offset = "0x193CF30", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetLocalAABB")]
	[Token(Token = "0x60003D5")]
	public void set_localBounds(Bounds value) { }

	[Address(RVA = "0x193DCE0", Offset = "0x193CEE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F5")]
	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[Address(RVA = "0x193D510", Offset = "0x193C710", Length = "0xBA")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EF")]
	public void set_material(Material value) { }

	[Address(RVA = "0x193DDC0", Offset = "0x193CFC0", Length = "0x8")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Renderer), Member = "SetMaterialArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003ED")]
	public void set_materials(Material[] value) { }

	[Address(RVA = "0x193DE20", Offset = "0x193D020", Length = "0x86")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E4")]
	public void set_receiveShadows(bool value) { }

	[Address(RVA = "0x193DDD0", Offset = "0x193CFD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000401")]
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x193DEF0", Offset = "0x193D0F0", Length = "0x83")]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E3")]
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	[Address(RVA = "0x193DEB0", Offset = "0x193D0B0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000400")]
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	[Address(RVA = "0x193D510", Offset = "0x193C710", Length = "0xBA")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F1")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0x193DDC0", Offset = "0x193CFC0", Length = "0x8")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Renderer), Member = "SetMaterialArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F2")]
	public void set_sharedMaterials(Material[] value) { }

	[Address(RVA = "0x193DFC0", Offset = "0x193D1C0", Length = "0x83")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E6")]
	public void set_sortingLayerID(int value) { }

	[Address(RVA = "0x193DF80", Offset = "0x193D180", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000403")]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x193E090", Offset = "0x193D290", Length = "0x83")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003E8")]
	public void set_sortingOrder(int value) { }

	[Address(RVA = "0x193E050", Offset = "0x193D250", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000405")]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x193D510", Offset = "0x193C710", Length = "0xBA")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	[Token(Token = "0x60003D8")]
	private void SetMaterial(Material m) { }

	[Address(RVA = "0x193D4C0", Offset = "0x193C6C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003F8")]
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	[Address(RVA = "0x193D320", Offset = "0x193C520", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	[Token(Token = "0x60003DA")]
	private void SetMaterialArray(Material[] m, int length) { }

	[Address(RVA = "0x193D3E0", Offset = "0x193C5E0", Length = "0xDE")]
	[CalledBy(Type = typeof(Renderer), Member = "set_materials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Renderer), Member = "set_sharedMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003DB")]
	private void SetMaterialArray(Material[] m) { }

	[Address(RVA = "0x193D2C0", Offset = "0x193C4C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003FA")]
	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	[Address(RVA = "0x193D220", Offset = "0x193C420", Length = "0x9C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DE")]
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

