//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\lsm.dll
// Interface ID: 1e665584-40fe-4450-8f6e-802362399694
// Interface Version: 1.0



namespace rpc_1e665584_40fe_4450_8f6e_802362399694_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(byte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<byte>(p0, p1, p2);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public byte[] Read_2()
        {
            return ReadConformantVaryingArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_1(Member8);
            m.WriteGuid(Member18);
            m.WriteGuid(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_1();
            Member18 = u.ReadGuid();
            Member28 = u.ReadGuid();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_1 Member8;
        public System.Guid Member18;
        public System.Guid Member28;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, Struct_1 Member8, System.Guid Member18, System.Guid Member28)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member18 = Member18;
            this.Member28 = Member28;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteEmbeddedPointer<byte[], long, long>(Member8, new System.Action<byte[], long, long>(m.Write_2), Member0, Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_2), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(short Member0, byte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("1e665584-40fe-4450-8f6e-802362399694", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcBroadcastSystemMessage(int p0, int p1, int p2, ref System.Nullable<int> p3, int p4, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p5, NtApiDotNet.Ndr.Marshal.NdrInt3264 p6, byte[] p7, int p8, sbyte p9, out int p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteInt32(p4);
            m.WriteUInt3264(p5);
            m.WriteInt3264(p6);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p8);
            m.WriteInt32(p8);
            m.WriteSByte(p9);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), true);
            p10 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSendWindowMessage(int p0, int p1, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p2, int p3, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p4, NtApiDotNet.Ndr.Marshal.NdrInt3264 p5, byte[] p6, int p7, sbyte p8, out int p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteUInt3264(p2);
            m.WriteInt32(p3);
            m.WriteUInt3264(p4);
            m.WriteInt3264(p5);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"), p7);
            m.WriteInt32(p7);
            m.WriteSByte(p8);
            _Unmarshal_Helper u = SendReceive(1, m);
            p9 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcCreateSession(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, int p2, int p3, out int p4, out System.Guid p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteEnum16(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadInt32();
            p5 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int RpcTerminateSession(int p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
