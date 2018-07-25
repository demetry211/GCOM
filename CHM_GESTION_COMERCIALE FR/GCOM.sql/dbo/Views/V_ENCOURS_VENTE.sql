CREATE VIEW [dbo].[V_ENCOURS_VENTE]
AS
select 'FC' as [TYPE PIECE], CODE_FACTURE as CODE_PIECE, CODE_CLIENT, MONTANT_TOTAL_FACTURE as MONTANT
, (select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=facture.CODE_FACTURE) as [MONTANT_REG],
 MONTANT_TOTAL_FACTURE - (select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=facture.CODE_FACTURE) as RESTE
	
from FACTURE
where 
MONTANT_TOTAL_FACTURE - (select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=facture.CODE_FACTURE)>0
union all

select 'TC' as [TYPE PIECE], CODE_TC as CODE_PIECE, CODE_CLIENT, MONTANT_TTC as MONTANT, 
(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=TICKET_CAISSE.CODE_TC) as [MONTANT_REG],
MONTANT_TTC - (select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=TICKET_CAISSE.CODE_TC) as RESTE
FROM TICKET_CAISSE
where (select COUNT(code_facture) 
		from FACTURE where TICKET_CAISSE.CODE_FACTURE=facture.CODE_FACTURE 
		and TICKET_CAISSE.CODE_CLIENT=facture.CODE_CLIENT)=0
and 
MONTANT_TTC - (select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=TICKET_CAISSE.CODE_TC)>0
union all

select 'BL' as TYPE_PIECE, BON_DE_LIVRAISON.CODE_B_LIV as CODE_PIECE, CODE_CLIENT,
(select SUM(LG_BON_LIVRAISON.PRIX_U_TTC* LG_BON_LIVRAISON.QTE_LIGNE_B_LIV) 
	from LG_BON_LIVRAISON
	where LG_BON_LIVRAISON.CODE_B_LIV=BON_DE_LIVRAISON.CODE_B_LIV) as MONTANT,
	(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=BON_DE_LIVRAISON.CODE_B_LIV) as [MONTANT_REG],
	(select SUM(LG_BON_LIVRAISON.PRIX_U_TTC* LG_BON_LIVRAISON.QTE_LIGNE_B_LIV) 
	from LG_BON_LIVRAISON
	where LG_BON_LIVRAISON.CODE_B_LIV=BON_DE_LIVRAISON.CODE_B_LIV)-
(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=BON_DE_LIVRAISON.CODE_B_LIV) as RESTE
from BON_DE_LIVRAISON
where (select COUNT(LIGNE_FACTURE.CODE_BL) 
from LIGNE_FACTURE where BON_DE_LIVRAISON.CODE_B_LIV=LIGNE_FACTURE.CODE_BL)=0
and 
(select SUM(LG_BON_LIVRAISON.PRIX_U_TTC* LG_BON_LIVRAISON.QTE_LIGNE_B_LIV) 
	from LG_BON_LIVRAISON
	where LG_BON_LIVRAISON.CODE_B_LIV=BON_DE_LIVRAISON.CODE_B_LIV)-
(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=BON_DE_LIVRAISON.CODE_B_LIV)>0

union all

select 'FI' as TYPE_PIECE , FICHE_INTERVENTION.NUM_FI, equipement.CODE_CLIENT,
(select SUM(LG_FI.P_HT_FI *LG_FI.QTE_FI*(1-LG_FI.REMISE_FI/100)*(1+LG_FI.TVA_FI/100))
from LG_FI
where LG_FI.NUM_FI=FICHE_INTERVENTION.NUM_FI
)
as MONTANT,
(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=FICHE_INTERVENTION.NUM_FI) as [MONTANT_REG], 
	(select SUM(LG_FI.P_HT_FI *LG_FI.QTE_FI*(1-LG_FI.REMISE_FI/100)*(1+LG_FI.TVA_FI/100))
from LG_FI
where LG_FI.NUM_FI=FICHE_INTERVENTION.NUM_FI
)-(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=FICHE_INTERVENTION.NUM_FI) as RESTE
from FICHE_INTERVENTION inner join equipement
on FICHE_INTERVENTION.CODE_VEHICULE=equipement.code_eqp
where 
(select SUM(LG_FI.P_HT_FI *LG_FI.QTE_FI*(1-LG_FI.REMISE_FI/100)*(1+LG_FI.TVA_FI/100))
from LG_FI
where LG_FI.NUM_FI=FICHE_INTERVENTION.NUM_FI
)-(select isnull(SUM(REGLEMENT_CLIENT.MONTANT_PIECE),0) 
	from REGLEMENT_CLIENT where REGLEMENT_CLIENT.CODE_FACTURE=FICHE_INTERVENTION.NUM_FI)>0
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ENCOURS_VENTE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ENCOURS_VENTE';

