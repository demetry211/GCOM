﻿CREATE TABLE [dbo].[FONCTION_UTILISATEUR] (
    [CODE_FONCTION_USER] DECIMAL (18)   NOT NULL,
    [LIB_FONCTION_USER]  NVARCHAR (MAX) NULL,
    [DESC_FONCTION_USER] NVARCHAR (MAX) NULL,
    [CODE_PRIVILEGE]     DECIMAL (18)   NOT NULL,
    CONSTRAINT [PK_FONCTION_UTILISATEUR] PRIMARY KEY CLUSTERED ([CODE_FONCTION_USER] ASC),
    CONSTRAINT [FK_FONCTION_UTILISATEUR_PRIVILEGE_UTILISATEUR] FOREIGN KEY ([CODE_PRIVILEGE]) REFERENCES [dbo].[PRIVILEGE_UTILISATEUR] ([CODE_PRIVILEGE])
);


GO
ALTER TABLE [dbo].[FONCTION_UTILISATEUR] NOCHECK CONSTRAINT [FK_FONCTION_UTILISATEUR_PRIVILEGE_UTILISATEUR];

