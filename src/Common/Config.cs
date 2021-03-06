﻿// MailServer - Easy and Fast Mailserver
//
// Copyright(C) 2020 Christopher Mogler
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with this program.If not, see<https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace MailServer.Common {
    public class Config {
        public static Config Current;
        public String Domain { get; set; }
        public String Listen { get; set; }
        public CertificateConfig Certificate { get; set; }
        public List<String> Accounts { get; set; }

        public class CertificateConfig
        {
            public String Filename { get; set; }
            public String Password { get; set; }
        }
    }
}
