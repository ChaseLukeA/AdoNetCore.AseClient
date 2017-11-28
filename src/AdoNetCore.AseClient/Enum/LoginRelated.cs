﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetCore.AseClient.Enum
{
    public enum LInt2 : byte
    {
        TDS_INT2_LSB_HI = 2,
        TDS_INT2_LSB_LO = 3,
    }
    public enum LInt4 : byte
    {

        TDS_INT4_LSB_HI = 0,
        TDS_INT4_LSB_LO = 1,
    }
    public enum LChar : byte
    {
        TDS_CHAR_ASCII = 6,
        TDS_CHAR_EBCDIC = 7,
    }
    public enum LFlt : byte
    {
        TDS_FLT_IEEE_HI = 4,
        TDS_FLT_VAXD = 5,
        TDS_FLT_IEEE_LO = 10,
        TDS_FLT_ND5000 = 11,
    }
    public enum LDt : byte
    {
        TDS_TWO_I4_LSB_HI = 8,
        TDS_TWO_I4_LSB_LO = 9,

    }

    public enum LUseDb : byte
    {
        TRUE = 1,
        FALSE = 0
    }

    public enum LDmpLd : byte
    {
        TRUE = 1,
        FALSE = 0
    }

    public enum LInterfaceSpare : byte
    {
        TDS_LDEFSQL = 0,
        TDS_LXSQL = 1,
        TDS_LSQL = 2,
        TDS_LSQL2_1 = 3,
        TDS_LSQL2_2 = 4,
        TDS_LOG_SUCCEED = 5,
        TDS_LOG_FAIL = 6,
        TDS_LOG_NEG = 7,
        TDS_LOG_SECSESS_ACK = 0x08
    }

    public enum LType : byte
    {
        TDS_NONE = 0x00, //added for our own use
        TDS_LSERVER = 0x01,
        TDS_LREMUSER = 0x02,
        TDS_LINTERNAL_RPC = 0x04
    }

    public enum MaxLength : int
    {
        TDS_MAXNAME = 30,
        TDS_RPLEN = 253,
        TDS_PROGNLEN = 10,
        TDS_VERSIZE = 4
    }

    public enum LNoShort : byte
    {
        TDS_CVT_SHORT = 1,
        TDS_NOCVT_SHORT = 0
    }

    public enum LFlt4 : byte
    {
        TDS_FLT4_IEEE_HI = (12),
        TDS_FLT4_IEEE_LO = (13),
        TDS_FLT4_VAXF = (14),
        TDS_FLT4_ND50004 = (15)
    }

    public enum LDate4 : byte
    {
        TDS_TWO_I2_LSB_HI = (16),
        TDS_TWO_I2_LSB_LO = (17)
    }

    public enum LSetLang : byte
    {
        TDS_NOTIFY = (1),
        TDS_NO_NOTIFY = (0)
    }

    public enum LSecLogin : byte
    {
        TDS_SEC_LOG_ENCRYPT = (0x01),
        TDS_SEC_LOG_CHALLENGE = (0x02),
        TDS_SEC_LOG_LABELS = (0x04),
        TDS_SEC_LOG_APPDEFINED = (0x08),
        TDS_SEC_LOG_SECSESS = (0x10),
        TDS_SEC_LOG_ENCRYPT2 = (0x20)
    }

    public enum LSecBulk : byte
    {
        TDS_SEC_BULK_LABELED = (0x01)
    }

    public enum LHaLogin : byte
    {
        TDS_HA_LOG_SESSION = (0x01),
        TDS_HA_LOG_RESUME = (0x02),
        TDS_HA_LOG_FAILOVERSRV = (0x04),
        TDS_HA_LOG_REDIRECT = (0x08),
        TDS_HA_LOG_MIGRATE = (0x10)
    }

    public enum LSetCharset : byte
    {
        TDS_NOTIFY = (1),
        TDS_NO_NOTIFY = (0)
    }
}
