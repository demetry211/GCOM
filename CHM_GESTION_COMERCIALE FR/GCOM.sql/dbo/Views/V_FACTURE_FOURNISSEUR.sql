CREATE VIEW [dbo].[V_FACTURE_FOURNISSEUR]
AS
SELECT     dbo.FACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR, dbo.FACTURE_FOURNISSEUR.NUM_FACT_FR, 
                      dbo.FACTURE_FOURNISSEUR.DATE_FACTURE_FOURNISSEUR, dbo.FACTURE_FOURNISSEUR.CODE_FOURNISSEUR, dbo.FOURNISSEUR.REF_FOURNISSEUR, 
                      dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.FOURNISSEUR.ADRESSE_FOURNISSEUR, dbo.FOURNISSEUR.TEL_FOURNISSEUR, 
                      dbo.FOURNISSEUR.FAX_FOURNISSEUR, dbo.FOURNISSEUR.EMAIL_FOURNISSEUR, dbo.FOURNISSEUR.CODE_TVA_FOURNISSEUR, 
                      dbo.FACTURE_FOURNISSEUR.USER_CREATION, UTILISATEUR_1.PRENOM_USER + ' ' + UTILISATEUR_1.NOM_USER AS UTILISATEUR_CREATION, 
                      dbo.FACTURE_FOURNISSEUR.DATE_CREATION, dbo.FACTURE_FOURNISSEUR.USER_MODIFICATION, 
                      dbo.UTILISATEUR.PRENOM_USER + ' ' + dbo.UTILISATEUR.NOM_USER AS UTILISATEUR_MODIFICATION, dbo.FACTURE_FOURNISSEUR.DATE_MODIFICATION, 
                      dbo.FACTURE_FOURNISSEUR.ANNULEE, dbo.FACTURE_FOURNISSEUR.USER_ANNULATION, 
                      UTILISATEUR_2.PRENOM_USER + ' ' + UTILISATEUR_2.NOM_USER AS UTILISATEUR_ANNULATION, dbo.FACTURE_FOURNISSEUR.DATE_ANNULATION, 
                      SUM(dbo.LG_FACT_FR.PRIX_HT * (1 + dbo.LG_FACT_FR.FODEC / 100) * dbo.LG_FACT_FR.QTE) AS TOTAL_HT, 
                      SUM((dbo.LG_FACT_FR.PRIX_HT * (1 + dbo.LG_FACT_FR.FODEC / 100)) * (dbo.LG_FACT_FR.REMISE / 100) * dbo.LG_FACT_FR.QTE) AS TOTAL_REMISE, 
                      SUM(((dbo.LG_FACT_FR.PRIX_HT * (1 + dbo.LG_FACT_FR.FODEC / 100)) * (1 - dbo.LG_FACT_FR.REMISE / 100)) * (dbo.LG_FACT_FR.TAUX_TVA / 100) 
                      * dbo.LG_FACT_FR.QTE) AS TOTAL_TVA
FROM         dbo.FACTURE_FOURNISSEUR INNER JOIN
                      dbo.FOURNISSEUR ON dbo.FOURNISSEUR.CODE_FOURNISSEUR = dbo.FACTURE_FOURNISSEUR.CODE_FOURNISSEUR LEFT OUTER JOIN
                      dbo.UTILISATEUR AS UTILISATEUR_1 ON dbo.FACTURE_FOURNISSEUR.USER_CREATION = UTILISATEUR_1.CODE_USER LEFT OUTER JOIN
                      dbo.UTILISATEUR ON dbo.UTILISATEUR.CODE_USER = dbo.FACTURE_FOURNISSEUR.USER_MODIFICATION LEFT OUTER JOIN
                      dbo.UTILISATEUR AS UTILISATEUR_2 ON dbo.FACTURE_FOURNISSEUR.USER_ANNULATION = UTILISATEUR_2.CODE_USER INNER JOIN
                      dbo.LG_FACT_FR ON dbo.FACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR = dbo.LG_FACT_FR.CODE_FACTURE_FOURNISSEUR
GROUP BY dbo.FACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR, dbo.FACTURE_FOURNISSEUR.NUM_FACT_FR, 
                      dbo.FACTURE_FOURNISSEUR.DATE_FACTURE_FOURNISSEUR, dbo.FACTURE_FOURNISSEUR.CODE_FOURNISSEUR, dbo.FOURNISSEUR.REF_FOURNISSEUR, 
                      dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.FOURNISSEUR.ADRESSE_FOURNISSEUR, dbo.FOURNISSEUR.TEL_FOURNISSEUR, 
                      dbo.FOURNISSEUR.FAX_FOURNISSEUR, dbo.FOURNISSEUR.EMAIL_FOURNISSEUR, dbo.FOURNISSEUR.CODE_TVA_FOURNISSEUR, 
                      dbo.FACTURE_FOURNISSEUR.USER_CREATION, UTILISATEUR_1.PRENOM_USER, UTILISATEUR_1.NOM_USER, dbo.FACTURE_FOURNISSEUR.DATE_CREATION, 
                      dbo.FACTURE_FOURNISSEUR.USER_MODIFICATION, dbo.UTILISATEUR.PRENOM_USER, dbo.UTILISATEUR.NOM_USER, 
                      dbo.FACTURE_FOURNISSEUR.DATE_MODIFICATION, dbo.FACTURE_FOURNISSEUR.ANNULEE, dbo.FACTURE_FOURNISSEUR.USER_ANNULATION, 
                      UTILISATEUR_2.PRENOM_USER, UTILISATEUR_2.NOM_USER, dbo.FACTURE_FOURNISSEUR.DATE_ANNULATION
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FACTURE_FOURNISSEUR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'500
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
   Begin CriteriaPane = 
      PaneHidden = 
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FACTURE_FOURNISSEUR';


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
         Configuration = "(H (1[34] 2[40] 3) )"
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
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FACTURE_FOURNISSEUR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "UTILISATEUR_1"
            Begin Extent = 
               Top = 6
               Left = 313
               Bottom = 114
               Right = 512
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR"
            Begin Extent = 
               Top = 6
               Left = 550
               Bottom = 114
               Right = 749
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR_2"
            Begin Extent = 
               Top = 150
               Left = 321
               Bottom = 258
               Right = 520
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LG_FACT_FR"
            Begin Extent = 
               Top = 280
               Left = 225
               Bottom = 388
               Right = 462
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "FOURNISSEUR"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
         Width = 284
         Width = 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FACTURE_FOURNISSEUR';

