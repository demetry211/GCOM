
CREATE VIEW [dbo].[V_ARTICLE_POS]
AS
SELECT         dbo.ARTICLE.CODE_BARRE_ARTICLE, dbo.ARTICLE.CODE_ARTICLE, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.ETAT_ARTICLE, 
                         dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.PRIX_HT_A_ARTICLE, dbo.ARTICLE.PRIX_HT_V_ARTICLE, dbo.TVA.TAUX_TVA AS TVA_ARTICLE,  dbo.STOCK.QTTE_STOCK, 
                         dbo.STOCK.CODE_MAG, dbo.MAGAZIN.NOM_MAG, dbo.UNITE.LIB_UNITE, dbo.UNITE.CODE_UNITE, TVA_1.TAUX_TVA AS TVA_ACHAT
FROM            dbo.ARTICLE INNER JOIN
                         dbo.STOCK ON dbo.ARTICLE.CODE_ARTICLE = dbo.STOCK.CODE_ARTICLE INNER JOIN
                         dbo.MAGAZIN ON dbo.STOCK.CODE_MAG = dbo.MAGAZIN.CODE_MAG INNER JOIN
                         dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE INNER JOIN
                         dbo.TVA ON dbo.ARTICLE.CODE_TVA = dbo.TVA.CODE_TVA INNER JOIN
                         dbo.TVA AS TVA_1 ON dbo.ARTICLE.TVA_ACHAT = TVA_1.CODE_TVA
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE_POS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE_POS';


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
         Begin Table = "ARTICLE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 271
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "STOCK"
            Begin Extent = 
               Top = 6
               Left = 309
               Bottom = 99
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAGAZIN"
            Begin Extent = 
               Top = 6
               Left = 538
               Bottom = 114
               Right = 729
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UNITE"
            Begin Extent = 
               Top = 102
               Left = 309
               Bottom = 180
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TVA"
            Begin Extent = 
               Top = 126
               Left = 67
               Bottom = 204
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TVA_1"
            Begin Extent = 
               Top = 75
               Left = 697
               Bottom = 171
               Right = 867
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
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE_POS';

