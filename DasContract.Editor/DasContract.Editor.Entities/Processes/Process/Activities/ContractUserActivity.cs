﻿
using System;
using System.Collections.Generic;
using DasContract.Editor.Entities.Forms;
using DasContract.Editor.Entities.Interfaces;
using DasContract.Editor.Migrator.Interfaces;

namespace DasContract.Editor.Entities.Processes.Process.Activities
{
    public class ContractUserActivity : ContractActivity, IDataCopyable<ContractUserActivity>, IMigratableComponent<ContractUserActivity, IMigrator>
    {
        public ContractForm Form
        {
            get => form.WithMigrator(Migrator);
            set
            {
                if (value != form)
                    Migrator.Notify(() => form, e => form = e);
                form = value;
            }
        }
        ContractForm form;

        public void CopyDataFrom(ContractUserActivity source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Form = source.Form;
        }

        public ContractUserActivity WithMigrator(IMigrator parentMigrator)
        {
            Migrator = parentMigrator;
            return this;
        }
    }
}
