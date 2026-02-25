namespace RLD;

[Token(Token = "0x2000090")]
public class GizmoScalerHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001FE")]
	private int _handleId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FF")]
	private List<Int32> _scaleDragAxisIndices; //Field offset: 0x18

	[Token(Token = "0x1700018C")]
	public int HandleId
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000525")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700018D")]
	public List<Int32> ScaleDragAxisIndices
	{
		[Address(RVA = "0x3D16D0", Offset = "0x3D08D0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000526")]
		 get { } //Length: 104
	}

	[Address(RVA = "0x3D1600", Offset = "0x3D0800", Length = "0xD0")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "RegisterScalerHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "RegisterScalerHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000527")]
	public GizmoScalerHandle(int handleId, IEnumerable<Int32> scaleDragAxisIndices) { }

	[Address(RVA = "0x3D15A0", Offset = "0x3D07A0", Length = "0x51")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "IsScalerHandleRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000528")]
	public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000525")]
	public int get_HandleId() { }

	[Address(RVA = "0x3D16D0", Offset = "0x3D08D0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000526")]
	public List<Int32> get_ScaleDragAxisIndices() { }

}

