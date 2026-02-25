namespace UnityEngine.UIElements;

[Token(Token = "0x2000512")]
internal static class EventInterestReflectionUtils
{
	[Token(Token = "0x2000513")]
	private struct DefaultEventInterests
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40010C7")]
		public int DefaultActionCategories; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40010C8")]
		public int DefaultActionAtTargetCategories; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40010C9")]
		public int HandleEventTrickleDownCategories; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40010CA")]
		public int HandleEventBubbleUpCategories; //Field offset: 0xC

	}

	[Token(Token = "0x40010C5")]
	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests; //Field offset: 0x0
	[Token(Token = "0x40010C6")]
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; //Field offset: 0x8

	[Address(RVA = "0x1B65F90", Offset = "0x1B65190", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600251B")]
	private static EventInterestReflectionUtils() { }

	[Address(RVA = "0x1B65860", Offset = "0x1B64A60", Length = "0x21A")]
	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetEventCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002519")]
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	[Address(RVA = "0x1B65A80", Offset = "0x1B64C80", Length = "0x2EF")]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "ComputeDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.EventInterestReflectionUtils+DefaultEventInterests>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DefaultEventInterests)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002518")]
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories, out int handleEventTrickleDownCategories, out int handleEventBubbleUpCategories) { }

	[Address(RVA = "0x1B65D70", Offset = "0x1B64F70", Length = "0x214")]
	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "ComputeDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600251A")]
	internal static EventCategory GetEventCategory(Type eventType) { }

}

