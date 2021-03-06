using System;
using Microsoft.SPOT;

namespace Nwazet.Go.Imaging {
    // Based on MicroBuilder's code: http://www.microbuilder.eu/Projects/LPC1343ReferenceDesign/TFTLCDAPI.aspx
    public class Icons16 {
        public static ushort[] Alert = { 0x0000, 0x0000, 0x0180, 0x03C0, 0x03C0, 0x0660, 0x0660, 0x0E70, 0x0E70, 0x1E78, 0x3E7C, 0x3FFC, 0x7E7E, 0x7E7E, 0xFFFF, 0x0000 };
        public static ushort[] AlertInterior = { 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0180, 0x0180, 0x0180, 0x0180, 0x0180, 0x0180, 0x0000, 0x0180, 0x0180, 0x0000, 0x0000 };
        public static ushort[] Info = { 0x0000, 0x07F0, 0x0FF8, 0x1FFC, 0x3F3E, 0x7F3F, 0x7FFF, 0x7F3F, 0x7F3F, 0x7F3F, 0x7F3F, 0x7F3F, 0x3F3E, 0x1FFC, 0x0FF8, 0x07F0 };
        public static ushort[] InfoInterior = { 0x0000, 0x0000, 0x0000, 0x0000, 0x00C0, 0x00C0, 0x0000, 0x00C0, 0x00C0, 0x00C0, 0x00C0, 0x00C0, 0x00C0, 0x0000, 0x0000, 0x0000 };
        public static ushort[] Failed = { 0x0000, 0x07F0, 0x0FF8, 0x1FFC, 0x3FFE, 0x79CF, 0x788F, 0x7C1F, 0x7E3F, 0x7C1F, 0x788F, 0x79CF, 0x3FFE, 0x1FFC, 0x0FF8, 0x07F0 };
        public static ushort[] FailedInterior = { 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0630, 0x0770, 0x03E0, 0x01C0, 0x03E0, 0x0770, 0x0630, 0x0000, 0x0000, 0x0000, 0x0000 };
        public static ushort[] Passed = { 0x0000, 0x07F0, 0x0FF8, 0x1FFC, 0x3FFE, 0x7FEF, 0x7FC7, 0x7F8F, 0x731F, 0x783F, 0x7C7F, 0x7EFF, 0x3FFE, 0x1FFC, 0x0FF8, 0x07F0 };
        public static ushort[] PassedInterior = { 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0010, 0x0038, 0x0070, 0x0CE0, 0x07C0, 0x0380, 0x0100, 0x0000, 0x0000, 0x0000, 0x0000 };
        public static ushort[] Pointer = { 0x07C0, 0x1FF0, 0x3FF8, 0x3FF8, 0x7FFC, 0x7FFC, 0x7FFC, 0x7FFC, 0x7FFC, 0x7FFC, 0x3FF8, 0x1FF0, 0x0FE0, 0x07C0, 0x0380, 0x0100 };
        public static ushort[] PointerDot = { 0x0000, 0x0000, 0x0000, 0x0000, 0x0380, 0x07C0, 0x07C0, 0x07C0, 0x0380, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 };
        public static ushort[] Tag = { 0xFF00, 0xFF80, 0xCFC0, 0xCFE0, 0xFFF0, 0xFFF8, 0xFFFC, 0xFFFE, 0x7FFE, 0x3FFE, 0x1FFC, 0x0FF8, 0x07F0, 0x03E0, 0x01C0, 0x0000 };
        public static ushort[] TagDot = { 0x0000, 0x0000, 0x3000, 0x3000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 };
        public static ushort[] Tools = { 0x118C, 0x118C, 0x11FC, 0x11FC, 0x10F8, 0x1070, 0x1070, 0x3870, 0x1070, 0x3870, 0x3870, 0x3870, 0x3870, 0x3870, 0x3870, 0x3870 };
    }
}
