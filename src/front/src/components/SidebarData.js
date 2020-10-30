import React from 'react';
import * as AiIcons from "react-icons/ai";
import * as IoIcons from "react-icons/io";

export const SidebarData = [
{
  title: 'Home',
  path: '/',
  icon: <AiIcons.AiFillHome />,
  cName: 'nav-text'
},
{
  title: 'Crianças',
  path: '/Kids',
  icon: <IoIcons.IoMdPersonAdd />,
  cName: 'nav-text'
},
{
  title: 'Família',
  path: '/Families',
  icon: <IoIcons.IoMdPeople />,
  cName: 'nav-text'
}
]