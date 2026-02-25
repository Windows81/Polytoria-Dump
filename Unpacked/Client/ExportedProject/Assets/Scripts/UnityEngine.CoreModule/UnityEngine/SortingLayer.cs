namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[Token(Token = "0x200006B")]
public struct SortingLayer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D2")]
	private int m_Id; //Field offset: 0x0

	[Address(RVA = "0x193F410", Offset = "0x193E610", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	[Token(Token = "0x600013F")]
	public static int GetLayerValueFromID(int id) { }

}

