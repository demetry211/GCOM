CREATE VIEW [dbo].[V_DC]
AS
SELECT     dbo.DEVIS_CLIENT.CODE_DC, dbo.DEVIS_CLIENT.DATE_DC, dbo.DEVIS_CLIENT.DATE_VALIDITE, dbo.DEVIS_CLIENT.CODE_CLIENT, dbo.CLIENT.REF_CLIENT, 
                      dbo.CLIENT.RS_CLIENT, dbo.CLIENT.ADRESSE_CLIENT, dbo.CLIENT.CP_CLIENT, dbo.CLIENT.TEL_CLIENT, dbo.CLIENT.FAX_CLIENT, dbo.CLIENT.CODE_TVA_CLIENT,
                       dbo.DEVIS_CLIENT.MODE_PAIEMENT, dbo.DEVIS_CLIENT.OBSERVATION, dbo.DEVIS_CLIENT.UTILISATEUR_CREATION, 
                      dbo.UTILISATEUR.PRENOM_USER + ' ' + dbo.UTILISATEUR.NOM_USER AS NOM_UTILISATEUR, dbo.DEVIS_CLIENT.DATE_CREATION, 
                      dbo.DEVIS_CLIENT.RESPONSABLE, dbo.DEVIS_CLIENT.NB_IMPRIME, SUM(dbo.LG_DC.QTE * dbo.LG_DC.PRIX_U_HT) AS MONTANT_HT, 
                      SUM(dbo.LG_DC.QTE * dbo.LG_DC.PRIX_U_HT * dbo.LG_DC.REMISE / 100) AS MONTANT_REMISE_HT, 
                      SUM(dbo.LG_DC.QTE * dbo.LG_DC.PRIX_U_HT * dbo.LG_DC.REMISE / 100 * dbo.LG_DC.TVA / 100) AS MONTANT_REMISE_TTC, 
                      SUM((dbo.LG_DC.QTE * (dbo.LG_DC.PRIX_U_HT * (1 - dbo.LG_DC.REMISE / 100))) * (dbo.LG_DC.TVA / 100)) AS MONTANT_TVA, 
                      SUM((dbo.LG_DC.QTE * (dbo.LG_DC.PRIX_U_HT * (1 - dbo.LG_DC.REMISE / 100))) * (1 + dbo.LG_DC.TVA / 100)) AS MONTANT_TTC, dbo.DEVIS_CLIENT.TIMBRE
FROM         dbo.DEVIS_CLIENT INNER JOIN
                      dbo.CLIENT ON dbo.DEVIS_CLIENT.CODE_CLIENT = dbo.CLIENT.CODE_CLIENT INNER JOIN
                      dbo.UTILISATEUR ON dbo.DEVIS_CLIENT.UTILISATEUR_CREATION = dbo.UTILISATEUR.CODE_USER INNER JOIN
                      dbo.LG_DC ON dbo.DEVIS_CLIENT.CODE_DC = dbo.LG_DC.CODE_DC
GROUP BY dbo.DEVIS_CLIENT.CODE_DC, dbo.DEVIS_CLIENT.DATE_DC, dbo.DEVIS_CLIENT.DATE_VALIDITE, dbo.DEVIS_CLIENT.CODE_CLIENT, dbo.CLIENT.REF_CLIENT, 
                      dbo.CLIENT.RS_CLIENT, dbo.CLIENT.ADRESSE_CLIENT, dbo.CLIENT.CP_CLIENT, dbo.CLIENT.TEL_CLIENT, dbo.CLIENT.FAX_CLIENT, dbo.CLIENT.CODE_TVA_CLIENT,
                       dbo.DEVIS_CLIENT.MODE_PAIEMENT, dbo.DEVIS_CLIENT.OBSERVATION, dbo.DEVIS_CLIENT.UTILISATEUR_CREATION, dbo.DEVIS_CLIENT.DATE_CREATION, 
                      dbo.DEVIS_CLIENT.RESPONSABLE, dbo.DEVIS_CLIENT.NB_IMPRIME, dbo.UTILISATEUR.NOM_USER, dbo.UTILISATEUR.PRENOM_USER, dbo.DEVIS_CLIENT.TIMBRE
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_DC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_DC';


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
         Begin Table = "DEVIS_CLIENT"
            Begin Extent = 
               Top = 0
               Left = 308
               Bottom = 130
               Right = 528
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENT"
            Begin Extent = 
               Top = 8
               Left = 24
               Bottom = 138
               Right = 241
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR"
            Begin Extent = 
               Top = 2
               Left = 596
               Bottom = 135
               Right = 813
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LG_DC"
            Begin Extent = 
               Top = 132
               Left = 279
               Bottom = 262
               Right = 449
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
   Begin CriteriaPane =', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_DC';

