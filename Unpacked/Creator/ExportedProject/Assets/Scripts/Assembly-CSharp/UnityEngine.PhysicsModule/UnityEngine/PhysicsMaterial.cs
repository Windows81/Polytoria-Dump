namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsMaterial.h")]
[Token(Token = "0x2000026")]
public class PhysicsMaterial : object
{

	[Token(Token = "0x17000069")]
	public PhysicsMaterialCombine bounceCombine
	{
		[Address(RVA = "0x19EC440", Offset = "0x19EB640", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_BounceCombine", ReturnType = typeof(PhysicsMaterialCombine))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 118
		[Address(RVA = "0x19EC740", Offset = "0x19EB940", Length = "0x83")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_BounceCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000065")]
	public float bounciness
	{
		[Address(RVA = "0x19EC500", Offset = "0x19EB700", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_Bounciness", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000199")]
		 get { } //Length: 118
		[Address(RVA = "0x19EC820", Offset = "0x19EBA20", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Bounciness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000066")]
	public float dynamicFriction
	{
		[Address(RVA = "0x19EC5C0", Offset = "0x19EB7C0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_Friction", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019B")]
		 get { } //Length: 118
		[Address(RVA = "0x19EC900", Offset = "0x19EBB00", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000068")]
	public PhysicsMaterialCombine frictionCombine
	{
		[Address(RVA = "0x19EC680", Offset = "0x19EB880", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_FrictionCombine", ReturnType = typeof(PhysicsMaterialCombine))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019E")]
		 get { } //Length: 118
		[Address(RVA = "0x19EC9D0", Offset = "0x19EBBD0", Length = "0x83")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_FrictionCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000067")]
	public float staticFriction
	{
		[Address(RVA = "0x19ECAB0", Offset = "0x19EBCB0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019D")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x19EC390", Offset = "0x19EB590", Length = "0x67")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Bounciness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_FrictionCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_BounceCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsMaterial), Member = "Internal_CreateDynamicsMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterial), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000197")]
	public PhysicsMaterial() { }

	[Address(RVA = "0x19EC440", Offset = "0x19EB640", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_BounceCombine", ReturnType = typeof(PhysicsMaterialCombine))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A0")]
	public PhysicsMaterialCombine get_bounceCombine() { }

	[Address(RVA = "0x19EC400", Offset = "0x19EB600", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AA")]
	private static PhysicsMaterialCombine get_bounceCombine_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EC500", Offset = "0x19EB700", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_Bounciness", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000199")]
	public float get_bounciness() { }

	[Address(RVA = "0x19EC4C0", Offset = "0x19EB6C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A3")]
	private static float get_bounciness_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EC5C0", Offset = "0x19EB7C0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_Friction", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019B")]
	public float get_dynamicFriction() { }

	[Address(RVA = "0x19EC580", Offset = "0x19EB780", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A5")]
	private static float get_dynamicFriction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EC680", Offset = "0x19EB880", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "get_FrictionCombine", ReturnType = typeof(PhysicsMaterialCombine))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019E")]
	public PhysicsMaterialCombine get_frictionCombine() { }

	[Address(RVA = "0x19EC640", Offset = "0x19EB840", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A8")]
	private static PhysicsMaterialCombine get_frictionCombine_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EC210", Offset = "0x19EB410", Length = "0x17C")]
	[CalledBy(Type = typeof(PhysicsMaterial), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000198")]
	private static void Internal_CreateDynamicsMaterial(PhysicsMaterial mat, string name) { }

	[Address(RVA = "0x19EC1C0", Offset = "0x19EB3C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A2")]
	private static void Internal_CreateDynamicsMaterial_Injected(PhysicsMaterial mat, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x19EC740", Offset = "0x19EB940", Length = "0x83")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_BounceCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A1")]
	public void set_bounceCombine(PhysicsMaterialCombine value) { }

	[Address(RVA = "0x19EC700", Offset = "0x19EB900", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AB")]
	private static void set_bounceCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value) { }

	[Address(RVA = "0x19EC820", Offset = "0x19EBA20", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Bounciness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019A")]
	public void set_bounciness(float value) { }

	[Address(RVA = "0x19EC7D0", Offset = "0x19EB9D0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A4")]
	private static void set_bounciness_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19EC900", Offset = "0x19EBB00", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019C")]
	public void set_dynamicFriction(float value) { }

	[Address(RVA = "0x19EC8B0", Offset = "0x19EBAB0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	private static void set_dynamicFriction_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19EC9D0", Offset = "0x19EBBD0", Length = "0x83")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_FrictionCombine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsMaterialCombine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019F")]
	public void set_frictionCombine(PhysicsMaterialCombine value) { }

	[Address(RVA = "0x19EC990", Offset = "0x19EBB90", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A9")]
	private static void set_frictionCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value) { }

	[Address(RVA = "0x19ECAB0", Offset = "0x19EBCB0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019D")]
	public void set_staticFriction(float value) { }

	[Address(RVA = "0x19ECA60", Offset = "0x19EBC60", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	private static void set_staticFriction_Injected(IntPtr _unity_self, float value) { }

}

