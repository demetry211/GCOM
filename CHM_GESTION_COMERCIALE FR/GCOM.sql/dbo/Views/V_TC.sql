CREATE VIEW [dbo].[V_TC]
AS
SELECT     dbo.TICKET_CAISSE.CODE_TC, dbo.TICKET_CAISSE.DATE_TC, dbo.TICKET_CAISSE.CODE_CAISSE, dbo.TICKET_CAISSE.CODE_CLIENT, 
                      dbo.TICKET_CAISSE.MONTANT_HT, dbo.TICKET_CAISSE.REMISE, dbo.TICKET_CAISSE.MONTANT_TVA, dbo.TICKET_CAISSE.MONTANT_TTC, 
                      dbo.TICKET_CAISSE.MONTANT_RECU, dbo.TICKET_CAISSE.RESTE, dbo.TICKET_CAISSE.MAGASIN, dbo.TICKET_CAISSE.CODE_USER, 
                      dbo.TICKET_CAISSE.CODE_REGLEMENT, dbo.TICKET_CAISSE.CODE_FACTURE, dbo.CLIENT.REF_CLIENT, dbo.CLIENT.RS_CLIENT, 
                      dbo.UTILISATEUR.PRENOM_USER + ' ' + dbo.UTILISATEUR.NOM_USER AS NOM_UTILISATEUR
FROM         dbo.TICKET_CAISSE INNER JOIN
                      dbo.CLIENT ON dbo.TICKET_CAISSE.CODE_CLIENT = dbo.CLIENT.CODE_CLIENT INNER JOIN
                      dbo.UTILISATEUR ON dbo.TICKET_CAISSE.CODE_USER = dbo.UTILISATEUR.CODE_USER
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_TC';


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
         Begin Table = "TICKET_CAISSE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENT"
            Begin Extent = 
               Top = 6
               Left = 267
               Bottom = 114
               Right = 464
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR"
            Begin Extent = 
               Top = 6
               Left = 502
               Bottom = 114
               Right = 701
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
      Begin ColumnWidths = 19
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_TC';

