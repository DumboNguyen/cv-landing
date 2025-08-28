import React from 'react';
import Navigation from '../Navigation/Navigation';
import './Header.css';

const Header: React.FC = () => {
  return (
    <header className="header">
      <div className="header-logo">
        <img src="/images/NQH-logo1.png" alt="NQH Logo" />
      </div>
      <Navigation />
    </header>
  );
};

export default Header;
