namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20002A7")]
public sealed class SortingGroup : Behaviour
{

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000219")]
	internal static int invalidSortingGroupID
	{
		[Address(RVA = "0x198F1B0", Offset = "0x198E3B0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D71")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700021A")]
	public int sortingLayerID
	{
		[Address(RVA = "0x198F220", Offset = "0x198E420", Length = "0x77")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D73")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700021B")]
	public int sortingOrder
	{
		[Address(RVA = "0x198F2E0", Offset = "0x198E4E0", Length = "0x77")]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D74")]
		 get { } //Length: 119
	}

	[Address(RVA = "0x198F1B0", Offset = "0x198E3B0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D71")]
	internal static int get_invalidSortingGroupID() { }

	[Address(RVA = "0x198F220", Offset = "0x198E420", Length = "0x77")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D73")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x198F1E0", Offset = "0x198E3E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D76")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x198F2E0", Offset = "0x198E4E0", Length = "0x77")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D74")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x198F2A0", Offset = "0x198E4A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D77")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x198F150", Offset = "0x198E350", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000D72")]
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	[Address(RVA = "0x198F110", Offset = "0x198E310", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D75")]
	private static IntPtr GetSortingGroupByIndex_Injected(int index) { }

}

