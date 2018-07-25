CREATE VIEW dbo.V_PIECE_ATTENTE_CLIENT
AS
SELECT     'CMD' AS TYPE_PIECE, dbo.COMMANDE.CODE_COMMANDE, dbo.COMMANDE.DATE_COMMANDE, ISNULL(dbo.COMMANDE.DATE_EXPIRATION_COMMANDE, N'') 
                      AS DATE_EXPIRATION_COMMANDE, dbo.ARTICLE.REF_ARTICLE, dbo.LIGNE_COMMANDE.CODE_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, 
                      dbo.ARTICLE.MARQUE_ARTICLE, dbo.ARTICLE.CODE_BARRE_ARTICLE, dbo.STOCK.QTTE_STOCK, dbo.MAGAZIN.CODE_MAG, 
                      dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE - dbo.LIGNE_COMMANDE.QTE_LIVRE AS QTE, dbo.COMMANDE.CODE_CLIENT, dbo.ARTICLE.PRIX_HT_V_ARTICLE, 
                      dbo.TVA.TAUX_TVA AS TVA_ARTICLE,  dbo.unite.CODE_UNITE, dbo.UNITE.LIB_UNITE
FROM         dbo.COMMANDE INNER JOIN
                      dbo.LIGNE_COMMANDE ON dbo.COMMANDE.CODE_COMMANDE = dbo.LIGNE_COMMANDE.CODE_COMMANDE INNER JOIN
                      dbo.ARTICLE ON dbo.LIGNE_COMMANDE.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN
                      dbo.STOCK ON dbo.ARTICLE.CODE_ARTICLE = dbo.STOCK.CODE_ARTICLE AND 
                      dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE - dbo.LIGNE_COMMANDE.QTE_LIVRE <= dbo.STOCK.QTTE_STOCK INNER JOIN
                      dbo.MAGAZIN ON dbo.STOCK.CODE_MAG = dbo.MAGAZIN.CODE_MAG INNER JOIN
                      TVA ON ARTICLE.CODE_TVA = TVA.CODE_TVA INNER JOIN
                      dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE
WHERE     (dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE > dbo.LIGNE_COMMANDE.QTE_LIVRE)
/*AND (dbo.STOCK.CODE_MAG = '1')*/ UNION ALL
SELECT     'FE' AS TYPE_PIECE, dbo.FICHE_INTERVENTION.NUM_FI, dbo.FICHE_INTERVENTION.DATE_FI, ISNULL(dbo.FICHE_INTERVENTION.DATE_CLOTURE, N'') 
                      AS DATE_EXPIRATION_COMMANDE, dbo.ARTICLE.REF_ARTICLE, dbo.LG_FI.CODE_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.MARQUE_ARTICLE, 
                      dbo.ARTICLE.CODE_BARRE_ARTICLE, dbo.STOCK.QTTE_STOCK, dbo.MAGAZIN.CODE_MAG, dbo.LG_FI.QTE_FI AS QTE, dbo.EQUIPEMENT.CODE_CLIENT, 
                      dbo.ARTICLE.PRIX_HT_V_ARTICLE, dbo.TVA.TAUX_TVA AS TVA_ARTICLE,  dbo.unite.CODE_UNITE, dbo.UNITE.LIB_UNITE
FROM         dbo.FICHE_INTERVENTION INNER JOIN
                      dbo.LG_FI ON dbo.FICHE_INTERVENTION.NUM_FI = dbo.LG_FI.NUM_FI INNER JOIN
                      dbo.ARTICLE ON dbo.LG_FI.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN
                      dbo.STOCK ON dbo.ARTICLE.CODE_ARTICLE = dbo.STOCK.CODE_ARTICLE AND dbo.LG_FI.QTE_FI <= dbo.STOCK.QTTE_STOCK INNER JOIN
                      dbo.MAGAZIN ON dbo.STOCK.CODE_MAG = dbo.MAGAZIN.CODE_MAG INNER JOIN
                      TVA ON ARTICLE.CODE_TVA = TVA.CODE_TVA INNER JOIN
                      EQUIPEMENT ON dbo.FICHE_INTERVENTION.CODE_VEHICULE = dbo.EQUIPEMENT .CODE_EQP  INNER JOIN
                      dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE
WHERE     (dbo.FICHE_INTERVENTION.CLOTURE = 'True')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_PIECE_ATTENTE_CLIENT';


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
      Begin ColumnWidths = 20
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_PIECE_ATTENTE_CLIENT';

