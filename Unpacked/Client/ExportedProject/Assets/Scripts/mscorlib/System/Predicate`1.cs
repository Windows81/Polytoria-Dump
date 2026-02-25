namespace System;

[Token(Token = "0x20000B1")]
public sealed class Predicate : MulticastDelegate
{

	[Address(RVA = "0xC44C90", Offset = "0xC43E90", Length = "0xA6")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetQuadrantFromAxesSigns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.AxisSign", "RLD.AxisSign"}, ReturnType = "RLD.PlaneQuadrantId")]
	[CalledBy(Type = "RLD.PlaneDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetFirstAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisDescriptor")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetSecondAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisDescriptor")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetFirstAxisSign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisSign")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetSecondAxisSign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisSign")]
	[CalledBy(Type = "UnityEngine.TextCore.NativeTextGenerationSettings", Member = "get_hasLink", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkLoop", Member = "FindPlayerLoopEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.LowLevel.PlayerLoopSystem+UpdateFunction", "UnityEngine.LowLevel.PlayerLoopSystem", typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.NetworkLoop", Member = "AddToPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.LowLevel.PlayerLoopSystem+UpdateFunction", typeof(Type), "UnityEngine.LowLevel.PlayerLoopSystem&", typeof(Type), "Mirror.NetworkLoop+AddMode"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E4")]
	public Predicate`1(object object, IntPtr method) { }

	[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E5")]
	public override bool Invoke(T obj) { }

}

