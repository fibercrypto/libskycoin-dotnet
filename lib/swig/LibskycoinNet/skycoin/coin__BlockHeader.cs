//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace skycoin {

public class coin__BlockHeader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal coin__BlockHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(coin__BlockHeader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~coin__BlockHeader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_coin__BlockHeader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int isEqual(coin__BlockHeader bh) {
    int ret = skycoinPINVOKE.coin__BlockHeader_isEqual(swigCPtr, coin__BlockHeader.getCPtr(bh));
    return ret;
  }

  public uint Version {
    set {
      skycoinPINVOKE.coin__BlockHeader_Version_set(swigCPtr, value);
    } 
    get {
      uint ret = skycoinPINVOKE.coin__BlockHeader_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ulong Time {
    set {
      skycoinPINVOKE.coin__BlockHeader_Time_set(swigCPtr, value);
    } 
    get {
      ulong ret = skycoinPINVOKE.coin__BlockHeader_Time_get(swigCPtr);
      return ret;
    } 
  }

  public ulong BkSeq {
    set {
      skycoinPINVOKE.coin__BlockHeader_BkSeq_set(swigCPtr, value);
    } 
    get {
      ulong ret = skycoinPINVOKE.coin__BlockHeader_BkSeq_get(swigCPtr);
      return ret;
    } 
  }

  public ulong Fee {
    set {
      skycoinPINVOKE.coin__BlockHeader_Fee_set(swigCPtr, value);
    } 
    get {
      ulong ret = skycoinPINVOKE.coin__BlockHeader_Fee_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_GoUint8_ PrevHash {
    set {
      skycoinPINVOKE.coin__BlockHeader_PrevHash_set(swigCPtr, SWIGTYPE_p_GoUint8_.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.coin__BlockHeader_PrevHash_get(swigCPtr);
      SWIGTYPE_p_GoUint8_ ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GoUint8_(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_GoUint8_ BodyHash {
    set {
      skycoinPINVOKE.coin__BlockHeader_BodyHash_set(swigCPtr, SWIGTYPE_p_GoUint8_.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.coin__BlockHeader_BodyHash_get(swigCPtr);
      SWIGTYPE_p_GoUint8_ ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GoUint8_(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_GoUint8_ UxHash {
    set {
      skycoinPINVOKE.coin__BlockHeader_UxHash_set(swigCPtr, SWIGTYPE_p_GoUint8_.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.coin__BlockHeader_UxHash_get(swigCPtr);
      SWIGTYPE_p_GoUint8_ ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GoUint8_(cPtr, false);
      return ret;
    } 
  }

  public coin__BlockHeader() : this(skycoinPINVOKE.new_coin__BlockHeader(), true) {
  }

}

}
