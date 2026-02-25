namespace UnityEngine;

[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
[Token(Token = "0x2000003")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	[NativeProperty("Alpha", False, TargetType::Function (0))]
	[Token(Token = "0x17000001")]
	public float alpha
	{
		[Address(RVA = "0x1CAC7D0", Offset = "0x1CAB9D0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.UI.UISpeechBubble", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setCanvasGroupAlpha>b__100_0", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Hide", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Hide", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000002")]
		 get { } //Length: 118
		[Address(RVA = "0x1CACA60", Offset = "0x1CABC60", Length = "0x86")]
		[CalledBy(Type = "Polytoria.UI.UISpeechBubble", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "set_Opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "SyncSetOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "<setCanvasGroupAlpha>b__100_1", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		 set { } //Length: 134
	}

	[NativeProperty("BlocksRaycasts", False, TargetType::Function (0))]
	[Token(Token = "0x17000003")]
	public bool blocksRaycasts
	{
		[Address(RVA = "0x1CAC710", Offset = "0x1CAB910", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 118
	}

	[NativeProperty("IgnoreParentGroups", False, TargetType::Function (0))]
	[Token(Token = "0x17000004")]
	public bool ignoreParentGroups
	{
		[Address(RVA = "0x1CAC8D0", Offset = "0x1CABAD0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		 get { } //Length: 118
		[Address(RVA = "0x1CACB40", Offset = "0x1CABD40", Length = "0x86")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		 set { } //Length: 134
	}

	[NativeProperty("Interactable", False, TargetType::Function (0))]
	[Token(Token = "0x17000002")]
	public bool interactable
	{
		[Address(RVA = "0x1CAC990", Offset = "0x1CABB90", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 get { } //Length: 118
		[Address(RVA = "0x1CACC20", Offset = "0x1CABE20", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "SyncSetInteractable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000005")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public CanvasGroup() { }

	[Address(RVA = "0x1CAC7D0", Offset = "0x1CAB9D0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.UI.UISpeechBubble", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setCanvasGroupAlpha>b__100_0", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Hide", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Hide", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	public float get_alpha() { }

	[Address(RVA = "0x1CAC790", Offset = "0x1CAB990", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAC710", Offset = "0x1CAB910", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public bool get_blocksRaycasts() { }

	[Address(RVA = "0x1CAC850", Offset = "0x1CABA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAC8D0", Offset = "0x1CABAD0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public bool get_ignoreParentGroups() { }

	[Address(RVA = "0x1CAC890", Offset = "0x1CABA90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAC990", Offset = "0x1CABB90", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MainMenuButton", Member = "UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public bool get_interactable() { }

	[Address(RVA = "0x1CAC950", Offset = "0x1CABB50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAC710", Offset = "0x1CAB910", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x1CACA60", Offset = "0x1CABC60", Length = "0x86")]
	[CalledBy(Type = "Polytoria.UI.UISpeechBubble", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "set_Opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "SyncSetOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "<setCanvasGroupAlpha>b__100_1", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public void set_alpha(float value) { }

	[Address(RVA = "0x1CACA10", Offset = "0x1CABC10", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1CACB40", Offset = "0x1CABD40", Length = "0x86")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public void set_ignoreParentGroups(bool value) { }

	[Address(RVA = "0x1CACAF0", Offset = "0x1CABCF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1CACC20", Offset = "0x1CABE20", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PlayerGUI", Member = "SyncSetInteractable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public void set_interactable(bool value) { }

	[Address(RVA = "0x1CACBD0", Offset = "0x1CABDD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	private static void set_interactable_Injected(IntPtr _unity_self, bool value) { }

}

