namespace EdiFabric.Templates.X12004010
{
    using EdiFabric.Core.Model.Edi.X12;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    
    
    public class X12Context : DbContext
    {
        public X12Context() : base("name=X12ConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AAA> AAA { get; set; }
        public DbSet<ACK> ACK { get; set; }
        public DbSet<ADV> ADV { get; set; }
        public DbSet<AMT> AMT { get; set; }
        public DbSet<AT5> AT5 { get; set; }
        public DbSet<AT7> AT7 { get; set; }
        public DbSet<AT8> AT8 { get; set; }
        public DbSet<B10> B10 { get; set; }
        public DbSet<B3> B3 { get; set; }
        public DbSet<BAK> BAK { get; set; }
        public DbSet<BAL> BAL { get; set; }
        public DbSet<BCT> BCT { get; set; }
        public DbSet<BEG> BEG { get; set; }
        public DbSet<BGN> BGN { get; set; }
        public DbSet<BHT> BHT { get; set; }
        public DbSet<BIG> BIG { get; set; }
        public DbSet<BIN> BIN { get; set; }
        public DbSet<BL> BL { get; set; }
        public DbSet<BNX> BNX { get; set; }
        public DbSet<BRA> BRA { get; set; }
        public DbSet<BSN> BSN { get; set; }
        public DbSet<BX> BX { get; set; }
        public DbSet<C2> C2 { get; set; }
        public DbSet<C3> C3 { get; set; }
        public DbSet<CAD> CAD { get; set; }
        public DbSet<CB1> CB1 { get; set; }
        public DbSet<CD3> CD3 { get; set; }
        public DbSet<CLD> CLD { get; set; }
        public DbSet<CM> CM { get; set; }
        public DbSet<CN1> CN1 { get; set; }
        public DbSet<CRC> CRC { get; set; }
        public DbSet<CRD> CRD { get; set; }
        public DbSet<CSH> CSH { get; set; }
        public DbSet<CTB> CTB { get; set; }
        public DbSet<CTP> CTP { get; set; }
        public DbSet<CTT> CTT { get; set; }
        public DbSet<CUR> CUR { get; set; }
        public DbSet<D9> D9 { get; set; }
        public DbSet<DIS> DIS { get; set; }
        public DbSet<DMG> DMG { get; set; }
        public DbSet<DTM> DTM { get; set; }
        public DbSet<DTP> DTP { get; set; }
        public DbSet<E1> E1 { get; set; }
        public DbSet<E4> E4 { get; set; }
        public DbSet<E5> E5 { get; set; }
        public DbSet<EFI> EFI { get; set; }
        public DbSet<EM> EM { get; set; }
        public DbSet<ETD> ETD { get; set; }
        public DbSet<F9> F9 { get; set; }
        public DbSet<FA1> FA1 { get; set; }
        public DbSet<FA2> FA2 { get; set; }
        public DbSet<FOB> FOB { get; set; }
        public DbSet<G05> G05 { get; set; }
        public DbSet<G26> G26 { get; set; }
        public DbSet<G36> G36 { get; set; }
        public DbSet<G39> G39 { get; set; }
        public DbSet<G40> G40 { get; set; }
        public DbSet<G43> G43 { get; set; }
        public DbSet<G53> G53 { get; set; }
        public DbSet<G54> G54 { get; set; }
        public DbSet<G55> G55 { get; set; }
        public DbSet<G61> G61 { get; set; }
        public DbSet<G62> G62 { get; set; }
        public DbSet<G69> G69 { get; set; }
        public DbSet<G72> G72 { get; set; }
        public DbSet<G93> G93 { get; set; }
        public DbSet<GA> GA { get; set; }
        public DbSet<GF> GF { get; set; }
        public DbSet<H1> H1 { get; set; }
        public DbSet<H2> H2 { get; set; }
        public DbSet<H3> H3 { get; set; }
        public DbSet<H6> H6 { get; set; }
        public DbSet<HL> HL { get; set; }
        public DbSet<IC> IC { get; set; }
        public DbSet<IM> IM { get; set; }
        public DbSet<INC> INC { get; set; }
        public DbSet<ISS> ISS { get; set; }
        public DbSet<IT1> IT1 { get; set; }
        public DbSet<IT3> IT3 { get; set; }
        public DbSet<IT8> IT8 { get; set; }
        public DbSet<ITD> ITD { get; set; }
        public DbSet<K1> K1 { get; set; }
        public DbSet<L0> L0 { get; set; }
        public DbSet<L1> L1 { get; set; }
        public DbSet<L11> L11 { get; set; }
        public DbSet<L3> L3 { get; set; }
        public DbSet<L4> L4 { get; set; }
        public DbSet<L5> L5 { get; set; }
        public DbSet<L7> L7 { get; set; }
        public DbSet<L9> L9 { get; set; }
        public DbSet<LDT> LDT { get; set; }
        public DbSet<LE> LE { get; set; }
        public DbSet<LEP> LEP { get; set; }
        public DbSet<LFG> LFG { get; set; }
        public DbSet<LFH> LFH { get; set; }
        public DbSet<LH1> LH1 { get; set; }
        public DbSet<LH2> LH2 { get; set; }
        public DbSet<LH3> LH3 { get; set; }
        public DbSet<LH4> LH4 { get; set; }
        public DbSet<LH6> LH6 { get; set; }
        public DbSet<LHE> LHE { get; set; }
        public DbSet<LHR> LHR { get; set; }
        public DbSet<LHT> LHT { get; set; }
        public DbSet<LIN> LIN { get; set; }
        public DbSet<LM> LM { get; set; }
        public DbSet<LQ> LQ { get; set; }
        public DbSet<LS> LS { get; set; }
        public DbSet<LX> LX { get; set; }
        public DbSet<M1> M1 { get; set; }
        public DbSet<M12> M12 { get; set; }
        public DbSet<M3> M3 { get; set; }
        public DbSet<M7> M7 { get; set; }
        public DbSet<MAN> MAN { get; set; }
        public DbSet<MEA> MEA { get; set; }
        public DbSet<MS1> MS1 { get; set; }
        public DbSet<MS2> MS2 { get; set; }
        public DbSet<MS3> MS3 { get; set; }
        public DbSet<MSG> MSG { get; set; }
        public DbSet<MTX> MTX { get; set; }
        public DbSet<N1> N1 { get; set; }
        public DbSet<N10> N10 { get; set; }
        public DbSet<N2> N2 { get; set; }
        public DbSet<N3> N3 { get; set; }
        public DbSet<N4> N4 { get; set; }
        public DbSet<N5> N5 { get; set; }
        public DbSet<N7> N7 { get; set; }
        public DbSet<N9> N9 { get; set; }
        public DbSet<NA> NA { get; set; }
        public DbSet<NM1> NM1 { get; set; }
        public DbSet<NTE> NTE { get; set; }
        public DbSet<NX2> NX2 { get; set; }
        public DbSet<OTI> OTI { get; set; }
        public DbSet<PAL> PAL { get; set; }
        public DbSet<PAM> PAM { get; set; }
        public DbSet<PCT> PCT { get; set; }
        public DbSet<PER> PER { get; set; }
        public DbSet<PI> PI { get; set; }
        public DbSet<PID> PID { get; set; }
        public DbSet<PKG> PKG { get; set; }
        public DbSet<PKL> PKL { get; set; }
        public DbSet<PO1> PO1 { get; set; }
        public DbSet<PO3> PO3 { get; set; }
        public DbSet<PO4> PO4 { get; set; }
        public DbSet<POD> POD { get; set; }
        public DbSet<PRF> PRF { get; set; }
        public DbSet<PS> PS { get; set; }
        public DbSet<PWK> PWK { get; set; }
        public DbSet<Q7> Q7 { get; set; }
        public DbSet<QTY> QTY { get; set; }
        public DbSet<R2> R2 { get; set; }
        public DbSet<R3> R3 { get; set; }
        public DbSet<R4> R4 { get; set; }
        public DbSet<R9> R9 { get; set; }
        public DbSet<RCD> RCD { get; set; }
        public DbSet<RED> RED { get; set; }
        public DbSet<REF> REF { get; set; }
        public DbSet<S1> S1 { get; set; }
        public DbSet<S2> S2 { get; set; }
        public DbSet<S5> S5 { get; set; }
        public DbSet<S9> S9 { get; set; }
        public DbSet<SAC> SAC { get; set; }
        public DbSet<SCH> SCH { get; set; }
        public DbSet<SDQ> SDQ { get; set; }
        public DbSet<SI> SI { get; set; }
        public DbSet<SLN> SLN { get; set; }
        public DbSet<SN1> SN1 { get; set; }
        public DbSet<SPI> SPI { get; set; }
        public DbSet<SPO> SPO { get; set; }
        public DbSet<SR> SR { get; set; }
        public DbSet<T1> T1 { get; set; }
        public DbSet<T2> T2 { get; set; }
        public DbSet<T3> T3 { get; set; }
        public DbSet<T6> T6 { get; set; }
        public DbSet<T8> T8 { get; set; }
        public DbSet<TAX> TAX { get; set; }
        public DbSet<TC2> TC2 { get; set; }
        public DbSet<TD1> TD1 { get; set; }
        public DbSet<TD3> TD3 { get; set; }
        public DbSet<TD4> TD4 { get; set; }
        public DbSet<TD5> TD5 { get; set; }
        public DbSet<TDS> TDS { get; set; }
        public DbSet<TED> TED { get; set; }
        public DbSet<TSD> TSD { get; set; }
        public DbSet<TXI> TXI { get; set; }
        public DbSet<V1> V1 { get; set; }
        public DbSet<VC> VC { get; set; }
        public DbSet<W03> W03 { get; set; }
        public DbSet<W06> W06 { get; set; }
        public DbSet<W10> W10 { get; set; }
        public DbSet<W12> W12 { get; set; }
        public DbSet<W27> W27 { get; set; }
        public DbSet<W28> W28 { get; set; }
        public DbSet<W6> W6 { get; set; }
        public DbSet<X1> X1 { get; set; }
        public DbSet<X7> X7 { get; set; }
        public DbSet<XH> XH { get; set; }
        public DbSet<YNQ> YNQ { get; set; }
        public DbSet<ZC1> ZC1 { get; set; }
        public DbSet<ST> ST { get; set; }
        public DbSet<SE> SE { get; set; }
        public DbSet<C001> C001 { get; set; }
        public DbSet<C002> C002 { get; set; }
        public DbSet<C040> C040 { get; set; }
        public DbSet<Loop_CD3_210> Loop_CD3_210 { get; set; }
        public DbSet<Loop_LX_210> Loop_LX_210 { get; set; }
        public DbSet<Loop_N1_210> Loop_N1_210 { get; set; }
        public DbSet<Loop_N1_210_2> Loop_N1_210_2 { get; set; }
        public DbSet<Loop_N1_210_3> Loop_N1_210_3 { get; set; }
        public DbSet<Loop_N7_210> Loop_N7_210 { get; set; }
        public DbSet<Loop_S5_210> Loop_S5_210 { get; set; }
        public DbSet<Loop_SPO_210> Loop_SPO_210 { get; set; }
        public DbSet<TS210> TS210 { get; set; }
        public DbSet<Loop_AT7_214> Loop_AT7_214 { get; set; }
        public DbSet<Loop_CD3_214> Loop_CD3_214 { get; set; }
        public DbSet<Loop_CD3_214_2> Loop_CD3_214_2 { get; set; }
        public DbSet<Loop_EFI_214> Loop_EFI_214 { get; set; }
        public DbSet<Loop_LX_214> Loop_LX_214 { get; set; }
        public DbSet<Loop_N1_214> Loop_N1_214 { get; set; }
        public DbSet<Loop_N1_214_2> Loop_N1_214_2 { get; set; }
        public DbSet<Loop_PRF_214> Loop_PRF_214 { get; set; }
        public DbSet<Loop_SPO_214> Loop_SPO_214 { get; set; }
        public DbSet<TS214> TS214 { get; set; }
        public DbSet<Loop_E1_404> Loop_E1_404 { get; set; }
        public DbSet<Loop_L0_404> Loop_L0_404 { get; set; }
        public DbSet<Loop_LH1_404> Loop_LH1_404 { get; set; }
        public DbSet<Loop_LS_404> Loop_LS_404 { get; set; }
        public DbSet<Loop_LX_404> Loop_LX_404 { get; set; }
        public DbSet<Loop_N1_404> Loop_N1_404 { get; set; }
        public DbSet<Loop_N1_404_2> Loop_N1_404_2 { get; set; }
        public DbSet<Loop_N1_404_3> Loop_N1_404_3 { get; set; }
        public DbSet<Loop_N7_404> Loop_N7_404 { get; set; }
        public DbSet<Loop_REF_404> Loop_REF_404 { get; set; }
        public DbSet<Loop_S1_404> Loop_S1_404 { get; set; }
        public DbSet<Loop_T1_404> Loop_T1_404 { get; set; }
        public DbSet<Loop_VC_404> Loop_VC_404 { get; set; }
        public DbSet<TS404> TS404 { get; set; }
        public DbSet<Loop_FA1_810> Loop_FA1_810 { get; set; }
        public DbSet<Loop_ISS_810> Loop_ISS_810 { get; set; }
        public DbSet<Loop_IT1_810> Loop_IT1_810 { get; set; }
        public DbSet<Loop_LM_810> Loop_LM_810 { get; set; }
        public DbSet<Loop_N1_810> Loop_N1_810 { get; set; }
        public DbSet<Loop_N9_810> Loop_N9_810 { get; set; }
        public DbSet<Loop_PID_810> Loop_PID_810 { get; set; }
        public DbSet<Loop_SAC_810> Loop_SAC_810 { get; set; }
        public DbSet<Loop_SLN_810> Loop_SLN_810 { get; set; }
        public DbSet<Loop_V1_810> Loop_V1_810 { get; set; }
        public DbSet<TS810> TS810 { get; set; }
        public DbSet<Loop_LM_824> Loop_LM_824 { get; set; }
        public DbSet<Loop_LQ_824> Loop_LQ_824 { get; set; }
        public DbSet<Loop_N1_824> Loop_N1_824 { get; set; }
        public DbSet<Loop_OTI_824> Loop_OTI_824 { get; set; }
        public DbSet<Loop_TED_824> Loop_TED_824 { get; set; }
        public DbSet<TS824> TS824 { get; set; }
        public DbSet<Loop_CRC_832> Loop_CRC_832 { get; set; }
        public DbSet<Loop_CTP_832> Loop_CTP_832 { get; set; }
        public DbSet<Loop_G39_832> Loop_G39_832 { get; set; }
        public DbSet<Loop_LFG_832> Loop_LFG_832 { get; set; }
        public DbSet<Loop_LIN_832> Loop_LIN_832 { get; set; }
        public DbSet<Loop_LM_832> Loop_LM_832 { get; set; }
        public DbSet<Loop_N1_832> Loop_N1_832 { get; set; }
        public DbSet<Loop_N1_832_2> Loop_N1_832_2 { get; set; }
        public DbSet<Loop_N9_832> Loop_N9_832 { get; set; }
        public DbSet<Loop_PKL_832> Loop_PKL_832 { get; set; }
        public DbSet<Loop_SLN_832> Loop_SLN_832 { get; set; }
        public DbSet<TS832> TS832 { get; set; }
        public DbSet<Loop_ADV_850> Loop_ADV_850 { get; set; }
        public DbSet<Loop_AMT_850> Loop_AMT_850 { get; set; }
        public DbSet<Loop_AMT_850_2> Loop_AMT_850_2 { get; set; }
        public DbSet<Loop_CB1_850> Loop_CB1_850 { get; set; }
        public DbSet<Loop_CTP_850> Loop_CTP_850 { get; set; }
        public DbSet<Loop_CTT_850> Loop_CTT_850 { get; set; }
        public DbSet<Loop_FA1_850> Loop_FA1_850 { get; set; }
        public DbSet<Loop_LDT_850> Loop_LDT_850 { get; set; }
        public DbSet<Loop_LDT_850_2> Loop_LDT_850_2 { get; set; }
        public DbSet<Loop_LM_850> Loop_LM_850 { get; set; }
        public DbSet<Loop_LS_850> Loop_LS_850 { get; set; }
        public DbSet<Loop_N1_850> Loop_N1_850 { get; set; }
        public DbSet<Loop_N1_850_2> Loop_N1_850_2 { get; set; }
        public DbSet<Loop_N1_850_3> Loop_N1_850_3 { get; set; }
        public DbSet<Loop_N1_850_4> Loop_N1_850_4 { get; set; }
        public DbSet<Loop_N9_850> Loop_N9_850 { get; set; }
        public DbSet<Loop_N9_850_2> Loop_N9_850_2 { get; set; }
        public DbSet<Loop_PID_850> Loop_PID_850 { get; set; }
        public DbSet<Loop_PKG_850> Loop_PKG_850 { get; set; }
        public DbSet<Loop_PO1_850> Loop_PO1_850 { get; set; }
        public DbSet<Loop_QTY_850> Loop_QTY_850 { get; set; }
        public DbSet<Loop_SAC_850> Loop_SAC_850 { get; set; }
        public DbSet<Loop_SAC_850_2> Loop_SAC_850_2 { get; set; }
        public DbSet<Loop_SCH_850> Loop_SCH_850 { get; set; }
        public DbSet<Loop_SLN_850> Loop_SLN_850 { get; set; }
        public DbSet<Loop_SPI_850> Loop_SPI_850 { get; set; }
        public DbSet<TS850> TS850 { get; set; }
        public DbSet<Loop_ACK_855> Loop_ACK_855 { get; set; }
        public DbSet<Loop_ADV_855> Loop_ADV_855 { get; set; }
        public DbSet<Loop_CTT_855> Loop_CTT_855 { get; set; }
        public DbSet<Loop_N1_855> Loop_N1_855 { get; set; }
        public DbSet<Loop_N1_855_2> Loop_N1_855_2 { get; set; }
        public DbSet<Loop_N1_855_3> Loop_N1_855_3 { get; set; }
        public DbSet<Loop_N9_855> Loop_N9_855 { get; set; }
        public DbSet<Loop_PID_855> Loop_PID_855 { get; set; }
        public DbSet<Loop_PKG_855> Loop_PKG_855 { get; set; }
        public DbSet<Loop_PO1_855> Loop_PO1_855 { get; set; }
        public DbSet<Loop_QTY_855> Loop_QTY_855 { get; set; }
        public DbSet<Loop_SAC_855> Loop_SAC_855 { get; set; }
        public DbSet<Loop_SCH_855> Loop_SCH_855 { get; set; }
        public DbSet<Loop_SLN_855> Loop_SLN_855 { get; set; }
        public DbSet<TS855> TS855 { get; set; }
        public DbSet<Loop_CLD_856> Loop_CLD_856 { get; set; }
        public DbSet<Loop_HL_856> Loop_HL_856 { get; set; }
        public DbSet<Loop_LH1_856> Loop_LH1_856 { get; set; }
        public DbSet<Loop_LM_856> Loop_LM_856 { get; set; }
        public DbSet<Loop_N1_856> Loop_N1_856 { get; set; }
        public DbSet<Loop_SAC_856> Loop_SAC_856 { get; set; }
        public DbSet<Loop_V1_856> Loop_V1_856 { get; set; }
        public DbSet<TS856> TS856 { get; set; }
        public DbSet<Loop_FA1_857> Loop_FA1_857 { get; set; }
        public DbSet<Loop_G05_857> Loop_G05_857 { get; set; }
        public DbSet<Loop_HL_857> Loop_HL_857 { get; set; }
        public DbSet<Loop_IT1_857> Loop_IT1_857 { get; set; }
        public DbSet<Loop_LM_857> Loop_LM_857 { get; set; }
        public DbSet<Loop_LX_857> Loop_LX_857 { get; set; }
        public DbSet<Loop_N1_857> Loop_N1_857 { get; set; }
        public DbSet<Loop_PAL_857> Loop_PAL_857 { get; set; }
        public DbSet<Loop_PID_857> Loop_PID_857 { get; set; }
        public DbSet<Loop_SAC_857> Loop_SAC_857 { get; set; }
        public DbSet<Loop_SLN_857> Loop_SLN_857 { get; set; }
        public DbSet<Loop_TDS_857> Loop_TDS_857 { get; set; }
        public DbSet<TS857> TS857 { get; set; }
        public DbSet<Loop_LM_861> Loop_LM_861 { get; set; }
        public DbSet<Loop_N1_861> Loop_N1_861 { get; set; }
        public DbSet<Loop_RCD_861> Loop_RCD_861 { get; set; }
        public DbSet<Loop_SLN_861> Loop_SLN_861 { get; set; }
        public DbSet<TS861> TS861 { get; set; }
        public DbSet<Loop_FA1_945> Loop_FA1_945 { get; set; }
        public DbSet<Loop_LM_945> Loop_LM_945 { get; set; }
        public DbSet<Loop_LS_945> Loop_LS_945 { get; set; }
        public DbSet<Loop_LX_945> Loop_LX_945 { get; set; }
        public DbSet<Loop_LX_945_2> Loop_LX_945_2 { get; set; }
        public DbSet<Loop_N1_945> Loop_N1_945 { get; set; }
        public DbSet<Loop_W12_945> Loop_W12_945 { get; set; }
        public DbSet<TS945> TS945 { get; set; }
    }
}