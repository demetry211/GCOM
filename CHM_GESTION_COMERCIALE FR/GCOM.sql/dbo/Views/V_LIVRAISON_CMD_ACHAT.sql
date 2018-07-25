CREATE VIEW [dbo].[V_LIVRAISON_CMD_ACHAT]
AS
SELECT     dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, dbo.LG_CMD_FR.CODE_ARTICLE, dbo.LG_CMD_FR.QTE, 
                      ISNULL(SUM(dbo.LG_BR_FR.QTE_LG_BR_FR), 0) AS QTE_LIVREE, dbo.COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR, dbo.LG_CMD_FR.PRIX_HT, 
                      dbo.LG_CMD_FR.REMISE, dbo.LG_CMD_FR.FODEC, dbo.LG_CMD_FR.TAUX_TVA, dbo.LG_CMD_FR.UNITE, dbo.LG_CMD_FR.CODE_UNITE_ARTICLE, 
                      dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.DESCRIPTION_ARTICLE
FROM         dbo.COMMANDE_FOURNISSEUR INNER JOIN
                      dbo.LG_CMD_FR ON dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR = dbo.LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR INNER JOIN
                      dbo.ARTICLE ON dbo.LG_CMD_FR.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE LEFT OUTER JOIN
                      dbo.LG_BR_FR ON dbo.LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR = dbo.LG_BR_FR.CODE_CMD_FR AND 
                      dbo.LG_CMD_FR.CODE_ARTICLE = dbo.LG_BR_FR.CODE_ARTICLE
WHERE     (dbo.COMMANDE_FOURNISSEUR.VALIDE = 'True')
GROUP BY dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, dbo.LG_CMD_FR.CODE_ARTICLE, dbo.LG_CMD_FR.QTE, 
                      dbo.COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR, dbo.LG_CMD_FR.PRIX_HT, dbo.LG_CMD_FR.REMISE, dbo.LG_CMD_FR.FODEC, 
                      dbo.LG_CMD_FR.TAUX_TVA, dbo.LG_CMD_FR.UNITE, dbo.LG_CMD_FR.CODE_UNITE_ARTICLE, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, 
                      dbo.ARTICLE.DESCRIPTION_ARTICLE
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_LIVRAISON_CMD_ACHAT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'e = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_LIVRAISON_CMD_ACHAT';


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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COMMANDE_FOURNISSEUR"
            Begin Extent = 
               Top = 16
               Left = 59
               Bottom = 124
               Right = 373
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "LG_CMD_FR"
            Begin Extent = 
               Top = 228
               Left = 368
               Bottom = 336
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "LG_BR_FR"
            Begin Extent = 
               Top = 156
               Left = 735
               Bottom = 333
               Right = 926
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "ARTICLE"
            Begin Extent = 
               Top = 236
               Left = 0
               Bottom = 344
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortTyp', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_LIVRAISON_CMD_ACHAT';

