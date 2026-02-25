namespace UnityEngine.Events;

[Token(Token = "0x20001C8")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000664")]
	private Object[] m_InvokeArray; //Field offset: 0x28

	[Address(RVA = "0x1993720", Offset = "0x1992920", Length = "0x1C8")]
	[CalledBy(Type = "UnityEngine.UI.Button+ButtonClickedEvent", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Button", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAuthenticator", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 7)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C52")]
	public UnityEvent() { }

	[Address(RVA = "0x1993230", Offset = "0x1992430", Length = "0x100")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.TimeoutAuthenticator", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.UnityEventHelper", Member = "AddListener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "System.Func`2<T, UnityEvent>", typeof(UnityAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "SetupClient", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "AddLeaderboardUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UIButton", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTPrefabScrollView", Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTPrefab"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C53")]
	public void AddListener(UnityAction call) { }

	[Address(RVA = "0x1993340", Offset = "0x1992540", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Token(Token = "0x6000C55")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x19933A0", Offset = "0x19925A0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C56")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x1993410", Offset = "0x1992610", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C57")]
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	[Address(RVA = "0x1993470", Offset = "0x1992670", Length = "0x25B")]
	[CalledBy(Type = "UnityEngine.UI.Button", Member = "Press", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAuthenticator", Member = "ClientAccept", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C58")]
	public void Invoke() { }

	[Address(RVA = "0x19936D0", Offset = "0x19928D0", Length = "0x49")]
	[CalledBy(Type = "RLD.RTPrefabScrollView", Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.RTPrefab"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkManager", Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.UnityEventHelper", Member = "RemoveListener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "System.Func`2<T, UnityEvent>", typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvokableCallList), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C54")]
	public void RemoveListener(UnityAction call) { }

}

