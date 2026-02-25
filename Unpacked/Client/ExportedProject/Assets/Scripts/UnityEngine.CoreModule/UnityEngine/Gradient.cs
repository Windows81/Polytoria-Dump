namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x20000F8")]
public class Gradient : IEquatable<Gradient>
{
	[Token(Token = "0x20000F9")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600071A")]
		public static IntPtr ConvertToNative(Gradient graident) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048F")]
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	[Address(RVA = "0x1945A80", Offset = "0x1944C80", Length = "0x3F")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600070F")]
	public Gradient() { }

	[Address(RVA = "0x1945AC0", Offset = "0x1944CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000710")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal Gradient(IntPtr ptr) { }

	[Address(RVA = "0x1945290", Offset = "0x1944490", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600070D")]
	private void Cleanup() { }

	[Address(RVA = "0x1945250", Offset = "0x1944450", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000717")]
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19452F0", Offset = "0x19444F0", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000714")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1945470", Offset = "0x1944670", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000715")]
	public override bool Equals(Gradient other) { }

	[Address(RVA = "0x1945550", Offset = "0x1944750", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000711")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x19455E0", Offset = "0x19447E0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000716")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19455F0", Offset = "0x19447F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	[Token(Token = "0x600070C")]
	private static IntPtr Init() { }

	[Address(RVA = "0x1945670", Offset = "0x1944870", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600070E")]
	private bool Internal_Equals(IntPtr other) { }

	[Address(RVA = "0x1945620", Offset = "0x1944820", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000718")]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x1945870", Offset = "0x1944A70", Length = "0x20F")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000712")]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	[Address(RVA = "0x1945730", Offset = "0x1944930", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "Gradient_Bindings::SetKeysWithSpans", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000713")]
	public void SetKeys(ReadOnlySpan<GradientColorKey> colorKeys, ReadOnlySpan<GradientAlphaKey> alphaKeys) { }

	[Address(RVA = "0x19456D0", Offset = "0x19448D0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000719")]
	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colorKeys, ref ManagedSpanWrapper alphaKeys) { }

}

