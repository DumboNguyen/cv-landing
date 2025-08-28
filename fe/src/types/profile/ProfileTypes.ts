import type { BaseEntity } from '../common/BaseTypes';

export interface Profile extends BaseEntity {
  name: string;
  title: string;
  avatar: string;
  email: string;
  phone: string;
  linkedin?: string;
  github?: string;
  location?: string;
}

export interface AboutMe {
  id: string;
  content: string;
  summary?: string;
}

export interface ContactInfo {
  email: string;
  phone: string;
  linkedin?: string;
  github?: string;
  location?: string;
}
