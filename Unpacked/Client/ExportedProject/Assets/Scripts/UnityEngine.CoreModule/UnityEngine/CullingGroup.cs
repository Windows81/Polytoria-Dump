namespace UnityEngine;

[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
[Token(Token = "0x2000085")]
public class CullingGroup
{
	[Token(Token = "0x2000086")]
	internal sealed class StateChanged : MulticastDelegate
	{

		[Address(RVA = "0x80C460", Offset = "0x80B660", Length = "0xA6")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023D")]
		public StateChanged(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		public override void Invoke(CullingGroupEvent sphere) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000192")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000193")]
	private StateChanged m_OnStateChanged; //Field offset: 0x18

	[Address(RVA = "0x19248D0", Offset = "0x1923AD0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600023C")]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

}

