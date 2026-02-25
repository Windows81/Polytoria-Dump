namespace UnityEngine;

[DefaultMember("Item")]
[HelpURL("AnimatorOverrideController")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[Token(Token = "0x2000015")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	[Token(Token = "0x2000016")]
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		public override void Invoke() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000045")]
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0x18

	[Address(RVA = "0x1915060", Offset = "0x1914260", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000A3")]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

