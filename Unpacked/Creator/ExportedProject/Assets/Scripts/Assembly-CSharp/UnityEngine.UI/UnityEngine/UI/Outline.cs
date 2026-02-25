namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Outline", 81)]
[Token(Token = "0x2000086")]
public class Outline : Shadow
{

	[Address(RVA = "0x1CC9530", Offset = "0x1CC8730", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shadow), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600053F")]
	protected Outline() { }

	[Address(RVA = "0x1CC91C0", Offset = "0x1CC83C0", Length = "0x36D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(Color32), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SplitUIVertexStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000540")]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

