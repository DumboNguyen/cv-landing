import React from 'react';
import './Navigation.css';

const Navigation: React.FC = () => {
  const menuItems = [
    { label: 'Experience', href: '#experience' },
    { label: 'Skill', href: '#skill' },
    { label: 'Education', href: '#education' },
    { label: 'Projects', href: '#projects' },
    { label: 'Testimonials', href: '#testimonials' },
    { label: 'Contact', href: '#contact' }
  ];

  return (
    <nav className="header-menu">
      {menuItems.map((item, index) => (
        <div key={index} className="header-menu-item">
          <a href={item.href}>{item.label}</a>
        </div>
      ))}
    </nav>
  );
};

export default Navigation;
