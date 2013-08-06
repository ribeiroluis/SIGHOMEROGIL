using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
//using DarumaFramework_CSharp;
using DarumaFramework_DLL;
//using System.Web.Mobile;


namespace DarumaFramework_DLL
{
       
    /// <summary>
    /// Classe para uso dos produtos DARUMA FRAMEWORK --DarumaFramework.dll--
    /// FrameWork de comunicacao que interliga todos os produtos DARUMA Automacao
    /// </summary>
    
    
    public class DarumaFramework_Declaracoes_CSharp

    {

        public static int iRetorno;
        public static string Str_LabelInputBox, Str_TextoInputBox, Str_Retorno_InputBox;
        
        public static string InputBox(string LB_stringInputBox, string TB_InputBox)
        {
            Str_LabelInputBox = string.Empty;
            Str_TextoInputBox = string.Empty;
            Str_Retorno_InputBox = string.Empty;

            Str_LabelInputBox = LB_stringInputBox;
            Str_TextoInputBox = TB_InputBox;

        //    FR_DarumaFramework_InputBox Form_Daruma = new FR_DarumaFramework_InputBox();
         //   Form_Daruma.ShowDialog();

            return Str_Retorno_InputBox;
        }

        #region Método Daruma DLL Framework

        #region Métodos DarumaFramework

        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirProduto_Daruma(System.String sProduto);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave_DarumaFramework(string sProduto, string sChave, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szRetorno);

        #endregion

        #region Métodos TA2000

        //*************Método TA2000*************

        //[DllImport("DarumaFrameWork.dll")]
      // public static extern int iEnviarDadosFormatados_TA2000_Daruma(string szTexto, string szRetorno);

        // Declaracao da Variavel por Referencia
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEnviarDadosFormatados_TA2000_Daruma(System.String szTexto, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPorta_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAuditoria_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMensagemBoasVindasLinha1_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMensagemBoasVindasLinha2_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMarcadorOpcao_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascara_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraLetra_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraNumero_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraEco_TA2000_Daruma(System.String stParametro);

        #endregion

        #region Métodos DUAL

        //*************Métodos para Impressoras Dual*************

        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEnviarBMP_DUAL_DarumaFramework(string stArqOrigem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirArquivo_DUAL_DarumaFramework(string stPath);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAcionarGaveta_DUAL_DarumaFramework ();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusGaveta_DUAL_DarumaFramework(ref int iStatusGaveta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusDocumento_DUAL_DarumaFramework ();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_DUAL_DarumaFramework ();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regVelocidade_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTermica_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTabulacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPortaComunicacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regModoGaveta_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLinhasGuilhotina_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regEnterFinal_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAguardarProcesso_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirTexto_DUAL_DarumaFramework(string stTexto, int iTam);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAutenticarDocumento_DUAL_DarumaFramework(string stTexto, string stLocal, string stTimeOut);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCodePageAutomatico_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regZeroCortado_DUAL_DarumaFramework(System.String stParametro);

        #endregion

        #region Métodos Modem

        [DllImport("DarumaFrameWork.dll")]
        public static extern int regApagar_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLerApagar_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPorta_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regThread_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regVelocidade_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnApagarSMS_MODEM_DarumaFramework(int iNumeroSMS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sResposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnFinalizar_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnInicializar_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnReseta_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerSMS_MODEM_DarumaFramework(int iNumeroSMS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sReposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerUltimoSMS_MODEM_DarumaFramework([MarshalAs(UnmanagedType.VBByRefStr)] ref string sResposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarComando_MODEM_DarumaFramework(string sComando, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sResposta, int iTamResposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarSMS_MODEM_DarumaFramework(string sNumeroTelefone, string sMensagem, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sResposta);

        #endregion

        #endregion

    }
}
