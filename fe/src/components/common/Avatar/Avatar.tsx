import React from 'react';
import './Avatar.css';

interface AvatarProps {
  src: string;
  alt: string;
  size?: 'small' | 'medium' | 'large';
  className?: string;
}

const Avatar: React.FC<AvatarProps> = ({
  src,
  alt,
  size = 'medium',
  className = ''
}) => {
  return (
    <img
      src={src}
      alt={alt}
      className={`avatar avatar-${size} ${className}`}
    />
  );
};

export default Avatar;
